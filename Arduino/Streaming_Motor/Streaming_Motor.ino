#include <MobaTools.h>

#define HOLDING true
#define ON_MOVE false 
#define PI 3.1415926535897932384626433832795
#define BUFFER_SIZE 500

const double time_step_ms = 4.50869073896708; // modify this time step in ms

// 200 steps = 1 revolution = 7.2 cm of shake table movement
const int steps_per_revolution = 2000;
const int base_steps_per_revolution = 200;
const double speed_scale_factor = steps_per_revolution/base_steps_per_revolution;
const double disp_scale_factor = speed_scale_factor;

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

double pos_from = 0;
double pos_to = 0;

#define ledPin 13

void setupTimer2() {
  noInterrupts();
  // Clear registers
  TCCR2A = 0;
  TCCR2B = 0;
  TCNT2 = 0;

  // 1000 Hz (16000000/((124+1)*128))
  OCR2A = 124;
  // CTC
  TCCR2A |= (1 << WGM21);
  // Prescaler 128
  TCCR2B |= (1 << CS22) | (1 << CS20);
  // Output Compare Match A Interrupt Enable
  TIMSK2 |= (1 << OCIE2A);
  interrupts();
}

void setup() {
  Serial.begin(500000);  // Make sure the baud rate matches the one set in your C# application
  pinMode(11, OUTPUT);
  
  stepper.attach(stepPin, dirPin);
  stepper.setSpeedSteps(steps_per_revolution);  // = 25000 steps/second (steps in 10 seconds)
  stepper.setZero();

  pinMode(ledPin, OUTPUT);
  setupTimer2();

}

void loop() 
{
  if (Serial.available() > 0) 
  {
    readData();    
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
      
      // // If there are space to store more data
      Serial.print("continue");

      // // Print received float value
      Serial.print("Received Float: ");
      Serial.println(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places

      // Increase the index
      move_buff_ptr_write++;
    }
    // else
    // {
    //   // Tell C# to wait until the data used up here to continue sending data
    //   // Prevent data fill up the buffer
    //   if(wait_count == 0)
    //   {
    //     movement_buffer[move_buff_ptr_write] = receivedFloat;
    //     Serial.print("Received Float: ");
    //     Serial.print(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places
    //   }

    //   Serial.print(wait_count);
    //   Serial.println("wait");
    //   wait_count++;

    // }
  }
}

  ISR(TIMER2_COMPA_vect) 
  {
    // If the readPTR hasn't catch up the write PTR
    if (move_buff_ptr_read < move_buff_ptr_write)
    {
      // the new position will be the next data from buffer
      pos_from = pos_to;
      pos_to = movement_buffer[move_buff_ptr_read];
      
      // increase the readPTR
      move_buff_ptr_read++;
      // If it reaches the end of the buffer
      if(move_buff_ptr_read == BUFFER_SIZE)
      {
        // Set the index back to 0
        move_buff_ptr_read = 0;
      }
    }

    double num_steps = num_steps_per_cm * (pos_to - pos_from) * disp_scale_factor;
    // Serial.println("Data");
    // Serial.println(counter);
    // Serial.println(num_steps);

    double steps_per_msecs = num_steps/time_step_ms;
    // Serial.println(steps_per_msecs);

    double steps_per_sec = steps_per_msecs * 1000 * speed_scale_factor;
      
    stepper.setSpeedSteps((uint16_t) steps_per_sec,0);
    stepper.move((long) num_steps);
  }




