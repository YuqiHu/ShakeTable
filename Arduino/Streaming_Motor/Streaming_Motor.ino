#include <MobaTools.h>

#define HOLDING true
#define ON_MOVE false 
#define PI 3.1415926535897932384626433832795
#define BUFFER_SIZE 5

const double time_step_ms = 4.50869073896708; // modify this time step in ms

// 200 steps = 1 revolution = 7.2 cm of shake table movement
const int steps_per_revolution = 1600;

// Buffer and pointer to read the whole file line by line
float movement_buffer[BUFFER_SIZE];
int move_buff_ptr_read = 0;
int move_buff_ptr_write = 0;
int read_loop_count = 0;
int write_loop_count = 0;

// Check the pin number on the Arduino board
const byte stepPin = 2;
const byte dirPin = 4;
//const byte cwPin = 11;
//const byte ccwPin = 12;

const double num_steps_per_cm = steps_per_revolution/7.2;
int counter = 0;
unsigned long timer = 0;

MoToStepper stepper(steps_per_revolution, STEPDIR); // steps per revolution, mode

bool mode = ON_MOVE;
bool moving = false;

void setup() {
  Serial.begin(500000);  // Make sure the baud rate matches the one set in your C# application
  pinMode(11, OUTPUT);
  
  stepper.attach(stepPin, dirPin);
  stepper.setSpeedSteps(steps_per_revolution);  // = 25000 steps/second (steps in 10 seconds)
  stepper.setZero();

}

void loop() 
{
  if (Serial.available() > 0) 
  {
    readData();

    double pos_from;
  
    if (mode == ON_MOVE && digitalRead(11) == HIGH) 
    {
        // Calculate steps and speed based of data
        
        timer = millis(); // Record current time
        memcpy_P(&pos_from, &disp_data[counter], sizeof(double));
        double num_steps = num_steps_per_cm * (pos_from);
        Serial.println("Data");
        Serial.println(counter);
        Serial.println(num_steps);

        double steps_per_msecs = num_steps/time_step_ms;
        Serial.println(steps_per_msecs);

        double steps_per_sec = steps_per_msecs * 1000;
        
        stepper.setSpeedSteps(steps_per_sec,0);
        stepper.move(num_steps);
        counter++;
        delay(time_step_ms - millis() + timer);
    }
    if (counter >= sizeof(disp_data) / sizeof(disp_data[0]) - 1){
      Serial.println("OFF");
      digitalWrite(11, LOW);
      mode = HOLDING;
      counter = 0;
    }
    
  }
}

float stringToFloat(String str) {
  char charBuf[20]; // Buffer to hold the characters of the string
  str.toCharArray(charBuf, 20); // Convert String to char array
  return atof(charBuf); // Use atof() function to convert char array to float
}

void readData()
{
  String receivedData = Serial.readStringUntil('#'); // Read until '#' delimiter
    
  // Convert string to float manually
  float receivedFloat = stringToFloat(receivedData);
  

  if(write_loop_count == read_loop_count && move_buff_ptr_write < BUFFER_SIZE)
  {
    // Adding the new data to the movement_buffer
    movement_buffer[move_buff_ptr_write] = receivedFloat;

    // If there are space to store more data
    Serial.print("continue");
    // Print received float value
    Serial.print("Received Float: ");
    Serial.println(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places

    // increase the index
    move_buff_ptr_write++;

    // Check if the write pointer reaches the end of the buffer
    if(move_buff_ptr_write == BUFFER_SIZE)
    {
      // Reset the write pointer to the beginning
      move_buff_ptr_write = 0;
      // Increase the loop count
      write_loop_count++;
    }
  }

  else if(write_loop_count > read_loop_count && move_buff_ptr_write < BUFFER_SIZE)
  {
    if(move_buff_ptr_write < (move_buff_ptr_read - 2))
    {
      // Adding the new data to the movement_buffer
      movement_buffer[move_buff_ptr_write] = receivedFloat;
      
      // If there are space to store more data
      Serial.print("continue");

      // // Print received float value
      Serial.print("Received Float: ");
      Serial.println(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places

      // Increase the index
      move_buff_ptr_write++;
    }
    else
    {
      // Tell C# to wait until the data used up here to continue sending data
      // Prevent data fill up the buffer
      if(wait_count == 0)
      {
        movement_buffer[move_buff_ptr_write] = receivedFloat;
        Serial.print("Received Float: ");
        Serial.print(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places
      }

      Serial.print(wait_count);
      Serial.println("wait");
      wait_count++;

    }
  }
}



