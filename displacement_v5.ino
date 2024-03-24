#include <Adafruit_MPU6050.h>

Adafruit_MPU6050 mpu;
Adafruit_Sensor *mpu_temp, *mpu_accel, *mpu_gyro;

unsigned long previousTime = 0;
float velocityX = 0.0; // in cm/s
float positionX = 0.0; // in cm
float prevFilteredAccelX = 0.0;
float alpha = 0.1; // Filter coefficient (0.0 - 1.0)
bool corrected = false;

void setup(void) {
  Serial.begin(115200);
  while (!Serial)
    delay(10); // will pause Zero, Leonardo, etc until serial console opens

  Serial.println("Adafruit MPU6050 test!");

  if (!mpu.begin()) {
    Serial.println("Failed to find MPU6050 chip");
    while (1) {
      delay(10);
    }
  }

  Serial.println("MPU6050 Found!");
  mpu_temp = mpu.getTemperatureSensor();
  mpu_temp->printSensorDetails();

  mpu_accel = mpu.getAccelerometerSensor();
  mpu_accel->printSensorDetails();

  mpu_gyro = mpu.getGyroSensor();
  mpu_gyro->printSensorDetails();

  mpu.setAccelerometerRange(2);
}

void loop() {
  unsigned long currentTime = millis();
  float deltaTime = (currentTime - previousTime) / 1000.0; // Convert milliseconds to seconds
  previousTime = currentTime;

  // Get sensor data
  sensors_event_t accel;
  sensors_event_t gyro;
  sensors_event_t temp;
  mpu_temp->getEvent(&temp);
  mpu_accel->getEvent(&accel);
  mpu_gyro->getEvent(&gyro);

  // Apply low-pass filter to acceleration data
  float filteredAccelX = alpha * accel.acceleration.x + (1 - alpha) * prevFilteredAccelX;
  prevFilteredAccelX = filteredAccelX;

  // Adjust filtered acceleration for any bias or calibration and convert to cm/s^2
  filteredAccelX -= 0.3565;
  filteredAccelX = (filteredAccelX * 100) / 9.80665; // Convert to cm/s^2

  // Calculate velocity using integration of acceleration (in cm/s^2)
  velocityX += filteredAccelX * deltaTime;

  // Calculate position using integration of velocity (in cm)
  positionX += velocityX * deltaTime;

  // Print data
  Serial.print("\tAccel X: ");
  Serial.print(accel.acceleration.x * 100, 2);
  Serial.println(" cm/s^2");

  Serial.print("\tFiltered Accel X: ");
  Serial.print(filteredAccelX, 2);
  Serial.println(" cm/s^2");

  if (!corrected && filteredAccelX >= 0.0 && positionX <= 0.0) {
    // Correct the position to 0.0
    velocityX -= velocityX;
    positionX -= positionX;
    corrected = true;
  }

  Serial.print("\tVelocity X: ");
  Serial.print(velocityX, 2);
  Serial.println(" cm/s");

  Serial.print("\tPosition X: ");
  Serial.print(positionX, 2);
  Serial.println(" cm");

  Serial.println();

  delay(1);
}