char c;
int i = 0;
char serial_buffer[20];


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:

  while(Serial.available()>0)
  {
    c = Serial.read();
    serial_buffer[i++] = c;
  }

  if(c == '#')
  {
    String appendSerialData = String(serial_buffer);
    Serial.print(":)");
    Serial.print("Arduino say >> ");
    Serial.println(appendSerialData);
    appendSerialData = "";
    c = 0;
  }



}
