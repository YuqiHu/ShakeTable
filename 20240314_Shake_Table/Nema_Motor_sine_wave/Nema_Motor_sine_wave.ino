#include <MobaTools.h>

#define HOLDING true
#define ON_MOVE false 
#define PI 3.1415926535897932384626433832795
#define BUFFER_SIZE 200

// Check the pin number on the Arduino board
const byte stepPin = 2;
const byte dirPin = 4;
//const byte cwPin = 11;
//const byte ccwPin = 12;

int counter = 0;
unsigned long timer = 0;

MoToStepper stepper(200, STEPDIR);

bool mode = false;
bool moving = false;

// Define amplitude and period of sine wave
float amplitude = 500; // Adjust as needed
float period = 500;   // Adjust as needed

float buffer[BUFFER_SIZE];
int writePTR = 0;
int readPTR = 0;
float pos = 0;

void setup()
{
  Serial.begin(500000);
  pinMode(11, OUTPUT);
  
  stepper.attach(stepPin, dirPin);
  stepper.setSpeedSteps(2000);  // = 200 steps/second (steps in 10 seconds)
  stepper.setRampLen(10);
  stepper.setZero();


  // Set up timer 
  cli();//stop interrupts

  //set timer0 interrupt at 2kHz
  TCCR0A = 0;// set entire TCCR0A register to 0
  TCCR0B = 0;// same for TCCR0B
  TCNT0  = 0;//initialize counter value to 0
  // set compare match register for 1khz increments
  OCR0A = 249;// = (16*10^6) / (1000*64) - 1 (must be <256)
  // turn on CTC mode
  TCCR0A |= (1 << WGM01);
  // Set CS01 and CS00 bits for 64 prescaler
  TCCR0B |= (1 << CS01) | (1 << CS00);   
  // enable timer compare interrupt
  TIMSK0 |= (1 << OCIE0A);

  sei();//allow interrupts
}

void loop()
{
  // If there is a new data
  if(Serial.available() > 0)
  {
    // read the input
    int input = Serial.read();

    // Start the program
    if(input == '1')
    {
      // turn it on
      // Serial.println("ON");
      digitalWrite(11, HIGH);
    }

    // Stop the program
    else if(input == '0')
    {
      // turn it off
      // Serial.println("OFF");
      digitalWrite(11, LOW);
    }
  }

  // If program starts, run the motor
  if (digitalRead(11) == HIGH)
  {

    // Check if there are any new data, if yes,
    // copy the data from C# as fast as possible
    while(Serial.available() > 0)
    {
      // Read the string data as 
      char c_data = Serial.read();
      Serial.println(c_data);
      // Convert char to float
      float f_data = atof(c_data);
      // write the data to the buffer
      buffer[writePTR] == f_data;
      // Move the pointer to the next position
      writePTR++;
      Serial.println(buffer[writePTR]);
      // If it reaches the end of the buffer, go to position 0
      if(writePTR == BUFFER_SIZE)
      {
        writePTR = 0;
      }
      Serial.setTimeout(1000);
    }

    //Serial.println("Yes");
    // Calculate steps amplitude and steps per second based on sine wave
    // int steps_amplitude = amplitude * sin(counter * 2 * PI / period);
    // int steps_per_secs = 500; // Adjust as needed

    // how many steps, speed (steps/sec * 10, 2000 = 200 sps)
    // moveStepper(steps_amplitude, steps_per_secs * 10);
    // moveStepper(pos);
    // time between move in millis() 
    // holdup(0);
    // counter++;
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

ISR(TIMER0_COMPA_vect)
{
  // If the readPTR hasn't catch up the write PTR
  if (readPTR < writePTR)
  {
    // the new position will be the next data from buffer
    pos = buffer[readPTR];
    // increase the readPTR
    readPTR++;
    // If it reaches the end of the buffer
    if(readPTR == BUFFER_SIZE)
    {
      // Set the index back to 0
      readPTR = 0;
    }
  }
}