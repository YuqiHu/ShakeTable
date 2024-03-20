#include <MobaTools.h>

#define HOLDING true
#define ON_MOVE false 
#define PI 3.1415926535897932384626433832795
#define CHAR_BUF_SIZE 20
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

// Buffer and pointer to read each single line of data
char serial_buffer[CHAR_BUF_SIZE];
int serial_buff_ptr = 0;

// Buffer and pointer to read the whole file line by line
float movement_buffer[BUFFER_SIZE];
int move_buff_ptr_read = 0;
int move_buff_ptr_write = 0;

void setup()
{
  // Open serial port and set the data rate to 500000 bit per second
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
  // For reading the file, we have two parts
  // 1. Read and write every digit in each line
  // 2. Read and write line by line

  // Step 1: Write each digit of the line
  // It reads every single digit of the position

  
  while(Serial.available() > 0 && serial_buff_ptr < CHAR_BUF_SIZE) // get the number of bytes or char available that already arrived and stored in the serial receive buffer
  {
      // read incoming serial data and store it into serial_buffer
      serial_buffer[serial_buff_ptr++] = Serial.read();
  }

  if (serial_buff_ptr >= CHAR_BUF_SIZE)
  {
    // Handle case where more serial data available than can be read into local buffer
  }

  // Check if this is the end of the line. Initial value FALSE
  bool containsEOL = false;

  // Initialize the EOL_loc variable
  int EOL_loc = -1;

  // Run through every position we have the buffer pointer
  for (int i=0; i<serial_buff_ptr; i++)
  {
    // If this is the end of each line of data
    if (serial_buffer[serial_buff_ptr] == '\n')
    {
      // Set the containsEOL = true
      containsEOL = true;
      // the end of line position is the current position
      EOL_loc = i;
    }
  }

  // If this is the end of the line 
  if(containsEOL)
  {
    // Convert the whole line from string to float
    float newValue = atof(serial_buffer);
    // Check 
    if (move_buff_ptr_write < BUFFER_SIZE)
    {
      // Put new float in buffer
      Serial.println("1");
      // Write the new value to the movement_buffer
      movement_buffer[move_buff_ptr_write] = newValue;
      // increase the pointer to the next value
      move_buff_ptr_write++;

    }
    else if(move_buff_ptr_write == BUFFER_SIZE && move_buff_ptr_read > 0)
    {
      Serial.println("2");
      // Move the buffer pointer back to 0
      move_buff_ptr_write == 0;
      // Write the new value to the beginning of the buffer
      movement_buffer[move_buff_ptr_write] = newValue;
    }

    // // Put new value into send to motor buffer
    // for (int i = EOL_loc; i<serial_buff_ptr; i++)
    // {
    //   serial_buffer[i-END_loc] = serial_buffer[i];
    // }
    // serial_buff_ptr = (serial_buff_ptr - END_loc);    
  }
}


// void loop()
// {
//   // If there is a new data
//   // if(Serial.available() > 0)
//   // {
//   //   // read the input
//   //   int input = Serial.read();

//   //   // Start the program
//   //   if(input == '1')
//   //   {
//   //     // turn it on
//   //     // Serial.println("ON");
//   //     digitalWrite(11, HIGH);
//   //   }

//   //   // Stop the program
//   //   else if(input == '0')
//   //   {
//   //     // turn it off
//   //     // Serial.println("OFF");
//   //     digitalWrite(11, LOW);
//   //   }
//   // }


//   // It reads every single digit of the position
//   while(Serial.available() > 0)
//   {
//     // If the serial is more than 
//     if(serial_buff_ptr >= 20)
//     {
//       Serial.println("The length of each line is more than 20 characters. Buffer is full.");
//       serial_buffer[serial_buff_ptr] = Serial.read();
//       Serial.println(serial_buffer[serial_buff_ptr]);
//     }

//     // If this is the end of the line, break the while loop
//       if(serial_buffer[-1] == "\n")
//       {
//         break;
//       }
//   }
//   // serial_buffer should now look like: [1][2].[1][2][3][4]...[\r][\n]




//     // if (digitalRead(11) == HIGH)
//     // {

//     //   // Check if there are any new data, if yes,
//     //   // copy the data from C# as fast as possible
//     //   while(Serial.available() > 0)
//     //   {
//     //     // Read the string data as 
//     //     char c_data = Serial.read();
//     //     Serial.println(c_data);
//     //     // Convert char to float
//     //     float f_data = atof(c_data);
//     //     // write the data to the buffer
//     //     buffer[writePTR] == f_data;
//     //     // Move the pointer to the next position
//     //     writePTR++;
//     //     Serial.println(buffer[writePTR]);
//     //     // If it reaches the end of the buffer, go to position 0
//     //     if(writePTR == BUFFER_SIZE)
//     //     {
//     //       writePTR = 0;
//     //     }
//     //     Serial.setTimeout(1000);
//     //   }

//       //Serial.println("Yes");
//       // Calculate steps amplitude and steps per second based on sine wave
//       // int steps_amplitude = amplitude * sin(counter * 2 * PI / period);
//       // int steps_per_secs = 500; // Adjust as needed

//       // how many steps, speed (steps/sec * 10, 2000 = 200 sps)
//       // moveStepper(steps_amplitude, steps_per_secs * 10);
//       // moveStepper(pos);
//       // time between move in millis() 
//       // holdup(0);
//       // counter++;
//     // }
//   // }
  
// }


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

// ISR(TIMER0_COMPA_vect)
// {
//   // If the readPTR hasn't catch up the write PTR
//   if (readPTR < writePTR)
//   {
//     // the new position will be the next data from buffer
//     pos = buffer[readPTR];
//     // increase the readPTR
//     readPTR++;
//     // If it reaches the end of the buffer
//     if(readPTR == BUFFER_SIZE)
//     {
//       // Set the index back to 0
//       readPTR = 0;
//     }
//   }
// }