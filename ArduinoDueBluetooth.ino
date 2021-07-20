
const char *container[] = 
{
"AT+PSWD=1234\r\n", //password  
"AT+RMAAD\r\n", //clears any previously paired devices.
"AT+ROLE=1\r\n", // puts the HC-05 in Master Mode.
"AT+RESET\r\n", //reset the HC-05.
"AT+CMODE=0\r\n", //allows the HC-05 to connect to any device.
"AT+INQM=0,5,9\r\n", //set inquiry to search for up to 5 devices for 9 seconds.
"AT+INIT\r\n", // initiates the SPP profile.
"AT+PAIR=19,10,92975,9\r\n", //Pair the HC-05 with the HC-06 //   3014,8,260604
"AT+BIND=19,10,92975\r\n", // Bind the HC-06 to the HC-05 
"AT+CMODE=1\r\n", // Set the HC-05 to only connect with paired devices
"AT+LINK=19,10,92975\r\n", //Link to the HC-06
};
int pin = 8;
int i = 0;
String c;
int tStop = 0;


void setup() 
{
  pinMode(pin, OUTPUT);
  Serial.begin(38400);
  Serial3.begin(38400);
}

/*
void CheckMessage()
{
  if (c == "OK\r\n")
  {  
    i = i + 1;
  }
  else
  {
    i = 0;
  }
  tStop = 0;
}
void ReadSerial()
{
  if (tStop < 2)
  {
      c = Serial3.readString();
      Serial.print(c);
      tStop = 2;
  }
}
void WriteToSerial()
{
  if (tStop < 1)
  {
        c = container[i];
        Serial.print(c); 
        Serial3.print(c);
        tStop = 1;
  }
}
*/
void ReadFromKey()
{
  if (Serial3.available())
    { 
      Serial.write(Serial3.read());
    }
  if (Serial.available())
    { 
      //Serial.write(Serial.read());
      Serial3.write(Serial.read());
    }
}

void loop() 
{
  digitalWrite(pin, HIGH);
  //while (i < 11)
  //  {
  //    WriteToSerial();
  //    delay(2000);
  //    ReadSerial();
  //    CheckMessage();
  //  } 
  ReadFromKey();
}



