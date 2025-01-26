#include <MobaTools.h>
#include "Data_file.h"

#define HOLDING true
#define ON_MOVE false 
#define PI 3.1415926535897932384626433832795

const double time_step_ms1 = 4.50869073896708; // modify this time step in ms
const double time_step_ms = 1;

// 200 steps = 1 revolution = 7.2 cm of shake table movement
const int steps_per_revolution = 2000;
const int base_steps_per_revolution = 200;
const double speed_scale_factor = steps_per_revolution/base_steps_per_revolution;
const double disp_scale_factor = speed_scale_factor;

// Check the pin number on the Arduino board
const byte stepPin = 2;
const byte dirPin = 4;
//const byte cwPin = 11;
//const byte ccwPin = 12;

const double num_steps_per_cm = steps_per_revolution/7.2;
int counter = 0;
int index = 0;
unsigned long timer = 0;

MoToStepper stepper(steps_per_revolution, STEPDIR); // steps per revolution, mode

bool mode = ON_MOVE;
bool moving = false;

void setup()
{
  Serial.begin(500000);
  pinMode(11, OUTPUT);
  
  stepper.attach(stepPin, dirPin);
  stepper.setSpeedSteps(steps_per_revolution);  // = 25000 steps/second (steps in 10 seconds)
  stepper.setZero();
}

void loop()
{
  //Serial.println("Hi!");
  if(Serial.available() > 0)
  {
    int input = Serial.read();
    Serial.println(input);

    if(input == '1')
    {
      // turn it on
      Serial.println("ON ");
      digitalWrite(11, HIGH);
    }

    else if(input == '0')
    {
      // turn it off
      Serial.println("OFF");
      digitalWrite(11, LOW);
    }
    Serial.println(digitalRead(11));
  }

  double pos_from;
  double pos_to;
  
  if (mode == ON_MOVE && digitalRead(11) == HIGH) {
    // Calculate steps and speed based of data
      
    timer = millis(); // Record current time
      
    //memcpy_P(&pos_from, &disp_data[counter], sizeof(double));
    //memcpy_P(&pos_to, &disp_data[counter+1], sizeof(double));
    if (counter < 8000 - 2) {
      memcpy_P(&pos_from, &sine_data_0[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_0[index+1], sizeof(float));
    }
    else if (counter < 16000 - 2) {
      memcpy_P(&pos_from, &sine_data_8000[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_8000[index+1], sizeof(float));
    }/*
    else if (counter < 24000 - 2) {
      memcpy_P(&pos_from, &sine_data_16000[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_16000[index+1], sizeof(float));
    }
    else if (counter < 32000 - 2) {
      memcpy_P(&pos_from, &sine_data_24000[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_24000[index+1], sizeof(float));
    }
    else if (counter < 40000 - 2) {
      memcpy_P(&pos_from, &sine_data_32000[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_32000[index+1], sizeof(float));
    }
    else if (counter < 48000 - 2) {
      memcpy_P(&pos_from, &sine_data_40000[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_40000[index+1], sizeof(float));
    }
    else if (counter < 56000 - 2) {
      memcpy_P(&pos_from, &sine_data_48000[index], sizeof(float));
      memcpy_P(&pos_to, &sine_data_48000[index+1], sizeof(float));
    }*/
    else {
      Serial.println("OFF");
      digitalWrite(11, LOW);
      mode = HOLDING;
    }
    double num_steps = num_steps_per_cm * (pos_to - pos_from) * disp_scale_factor;
    Serial.println("Data");
    Serial.println(counter);
    Serial.println(num_steps);

    double steps_per_msecs = num_steps/time_step_ms;
    Serial.println(steps_per_msecs);

    double steps_per_sec = steps_per_msecs * 1000 * speed_scale_factor;
      
    stepper.setSpeedSteps((uint16_t) steps_per_sec,0);
    stepper.move((long) num_steps);
    if (time_step_ms - millis() + timer > 0) delay(time_step_ms - millis() + timer);
    counter++;
    index++;
  }
  //if (counter >= sizeof(disp_data) / sizeof(disp_data[0]) - 1){
  if (index >= sizeof(sine_data_0)/ sizeof(sine_data_0[0]) - 2){
    //Serial.println("OFF");
    //digitalWrite(11, LOW);
    //mode = HOLDING;
    index = 0;
  }
}
