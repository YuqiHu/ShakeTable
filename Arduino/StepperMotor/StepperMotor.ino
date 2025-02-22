#define directionPin 2
#define stepPin 3

#define factor_of_precision 100000

// 200 steps = 1 revolution = 6.9 cm of shake table movement
const int pulse_per_revolution = 20000;
const int base_steps_per_revolution = 200;
const double speed_scale_factor = pulse_per_revolution/base_steps_per_revolution;
const double disp_scale_factor = speed_scale_factor;

// Calculate how many steps per cm
const double num_steps_per_cm = base_steps_per_revolution/6.9;

double start_position = 0.0;
double end_position = 0.0;
double time_step_ms = 0.0;

unsigned long previousMillis = 0;
int minMillis = 50;

void setup()
{
  pinMode(directionPin, OUTPUT);
  pinMode(stepPin, OUTPUT);
  Serial.begin(500000);
}

void loop()
{
  unsigned long currentMillis = millis();

  if (time_step_ms == 0.0 && Serial.available() > 0)
  {
    String receivedTimeData = Serial.readStringUntil('\n'); // Read until '\n'
    receivedTimeData.trim(); // Remove any whitespace or extra characters

    int startIndex = 0;
    while (startIndex < receivedTimeData.length() && !isdigit(receivedTimeData[startIndex])) {
        startIndex++; // Skip over non-numeric characters
    }

    // If we found a numeric character, extract the numeric portion of the string
    if (startIndex < receivedTimeData.length()) {
        receivedTimeData = receivedTimeData.substring(startIndex); // Keep the part from the first digit onwards
    }

    time_step_ms = receivedTimeData.toDouble();

    if (time_step_ms != 0.0) {
        Serial.println("Timestep OK"); // Send acknowledgment
    } else {
        Serial.println("Invalid Data");
    }

    return;
  }

  if(time_step_ms >= 10)
  {
    minMillis = 2; // If time steps >= 0.01 s
  }
  else
  {
    minMillis = 50; // If time steps < 0.01 s
  }

  if(currentMillis - previousMillis >= time_step_ms)
  {
    previousMillis = currentMillis;
  
    if (Serial.available() > 0)
    {    
      // Read the incoming serial data
      String receivedData = Serial.readStringUntil('\n');
      receivedData.trim(); // Remove any trailing spaces or newline characters

      if (receivedData.length() > 0)
      {
        start_position = end_position;
        end_position = receivedData.toDouble();
        
        float displacement_cm = (end_position - start_position) / factor_of_precision;
        int num_steps = abs(displacement_cm * num_steps_per_cm) * disp_scale_factor;
        
        if (displacement_cm > 0)
        {
          digitalWrite(directionPin, LOW); // Clockwise
        }
        else if (displacement_cm < 0)
        {
          digitalWrite(directionPin, HIGH); // Counterclockwise
        }

        int step_delay = (time_step_ms * 1000) / (2 * num_steps * disp_scale_factor); // Microseconds
        step_delay = max(step_delay, minMillis);

        for (int i = 0; i < num_steps; i++)
        {
          digitalWrite(stepPin, HIGH);
          delayMicroseconds(step_delay);
          digitalWrite(stepPin, LOW);
          delayMicroseconds(step_delay);
        }
        Serial.println("OK"); // Acknowledge completion

        // // ----- For Testing -----
        // Serial.println(num_steps);
      }
      else
      {
        Serial.println("INVALID COMMAND");
      }
    }
    else
    {
      // Do nothing or handle idle behavior here
      delay(100); // Optional: small delay to prevent excessive CPU usage
    }
  }
}