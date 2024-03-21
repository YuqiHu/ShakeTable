#define BUFFER_SIZE 5

// Buffer and pointer to read the whole file line by line
float movement_buffer[BUFFER_SIZE];
int move_buff_ptr_read = 0;
int move_buff_ptr_write = 0;
int read_loop_count = 0;
int write_loop_count = 0;

void setup() {
  Serial.begin(500000);  // Make sure the baud rate matches the one set in your C# application
}

void loop() {
  if (Serial.available() > 0) 
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
      // // Testing Code
      // move_buff_ptr_read = 4;
      if(move_buff_ptr_write < (move_buff_ptr_read - 2))
      {
        // Adding the new data to the movement_buffer
        movement_buffer[move_buff_ptr_write] = receivedFloat;
        
        // If there are space to store more data
        Serial.print("continue");

        // Print received float value
        Serial.print("Received Float: ");
        Serial.println(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places

        // Increase the index
        move_buff_ptr_write++;
      }
      else
      {
        // Tell C# to wait until the data used up here to continue sending data
        // Prevent data fill up the buffer
        movement_buffer[move_buff_ptr_write] = receivedFloat;

        Serial.print("wait ");
        Serial.print("Received Float: ");
        Serial.println(movement_buffer[move_buff_ptr_write], 10); // Print with 10 decimal places
        
        // Increase the index
        read_loop_count++;

        // // Testing code
        // move_buff_ptr_read = 0;
      }
    }
  }
}

float stringToFloat(String str) {
  char charBuf[20]; // Buffer to hold the characters of the string
  str.toCharArray(charBuf, 20); // Convert String to char array
  return atof(charBuf); // Use atof() function to convert char array to float
}



