#include <MobaTools.h>
#include <stdlib.h>

#define HOLDING true
#define ON_MOVE false 
#define PI 3.1415926535897932384626433832795
#define DELIMITING_CHAR '\n'

// Check the pin number on the Arduino board
const byte stepPin = 2;
const byte dirPin = 4;
//const byte cwPin = 11;
//const byte ccwPin = 12;

int num_steps_per_cm = 200/7.2;
int counter = 0;
unsigned long timer = 0;

MoToStepper stepper(200, STEPDIR);

bool mode = false;
bool moving = false;

// Define amplitude and period of sine wave
float amplitude = 500; // Adjust as needed
float period = 500;   // Adjust as needed

// Create a buffer for receiving data
float buffer[2000];

// // Displacement data structure
// struct DispData {
//   float time;
//   float displacement;
// };


// Displacement data


void setup()
{
  Serial.begin(500000);
  pinMode(11, OUTPUT);
  
  stepper.attach(stepPin, dirPin);
  stepper.setSpeedSteps(2000);  // = 200 steps/second (steps in 10 seconds)
  stepper.setRampLen(10);
  stepper.setZero();
}

void loop()
{

  Serial.println("Hi!");
  if(Serial.available() > 0)
  {
    int input = Serial.read();
    // Serial.println(input);

    if(input == '1')
    {
      // turn it on
      Serial.println("ON");
      digitalWrite(11, HIGH);
    }

    else if(input == '0')
    {
      // turn it off
      Serial.println("OFF");
      digitalWrite(11, LOW);
    }
    // Serial.println(digitalRead(11));
  }

  Serial.println("Hi2");
  //Serial.println(digitalRead(11));
  if (digitalRead(11) == HIGH)
  {
    // Serial.println(digitalRead(11));
    // if (Serial.available() > 0) 
    // {
    // // read the incoming byte:
    //   char incomingByte = Serial.read();

    //   // say what you got:
    //   Serial.print("I received: ");
    //   Serial.println(incomingByte, DEC);
    // }
    // if(Serial.available()>0)
    // {
    //   while(Serial.available()>0)
    //   {
    //     char data = Serial.read();
    //     Serial.println(data);
    //   }
    // }

    // char Cdata = Serial.read();
    // float pos = atof(Cdata);
    // Serial.println(pos);

    // counter = 0;
    // if(pos != 100)
    // {
    //   buffer[counter] = pos;
    //   counter++;
    //   Serial.println(pos);
    // }
    

    Serial.println(sizeof(disp_data) / sizeof(disp_data[0]));
    if (counter < (sizeof(disp_data) / sizeof(disp_data[0]) - 1)){
    Serial.println("Yes");
    Calculate steps amplitude and steps per second based on sine wave
    int steps_amplitude = amplitude * sin(counter * 2 * PI / period);
    int steps_per_secs = 500; // Adjust as needed

    // int num_steps = num_steps_per_cm * (disp_data[counter+1].displacement - disp_data[counter].displacement);
      
    // int steps_per_secs = num_steps/(disp_data[counter+1].time - disp_data[counter].time);


    how many steps, speed (steps/sec * 10, 2000 = 200 sps)
    moveStepper(steps_amplitude, steps_per_secs * 10);
    moveStepper(num_steps, steps_per_secs * 10);
    time between move in millis() 
    holdup(0);
    counter++;

  }
}

void moveStepper(long stepsToMove, long stepSpeed)
{
  if (mode == ON_MOVE) // time to go?  
  {
    if (moving == false) // stopped, set speed and steps. set to move
    {
      stepper.setSpeedSteps(stepSpeed);
      stepper.move(stepsToMove);
      moving = true;
    }
    else // in motion, check for ending position.  mode to hold on end
    {
      if (stepper.moving() == 0)
      {
        mode = HOLDING;
        moving = false;
        timer = millis(); // record current time
      }
    }
  }
}

void holdup(unsigned long stepDelay) // dwell between moves
{
  if (mode == HOLDING)
  {
    if (millis() - timer >= stepDelay)
    {
      mode = ON_MOVE; // time to move again
    }
  }
}
