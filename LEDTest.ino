int data = 0;                //Variable for storing received data
void setup() 
{
  Serial.begin(9600);         //Sets the data rate in bits per second (baud) for serial data transmission (Bluetooth transmission at a baud rate of 9600
   pinMode(7, OUTPUT);        //Sets digital pin 13 as output pin
   pinMode(6, OUTPUT);
   pinMode(5, OUTPUT);        //Sets digital pin 13 as output pin
  // Serial.begin(9600);
}


void loop()
{
  if(Serial.available() > 0)  // Send data only when you receive data:
  {
              data = Serial.read();      //Read the incoming data and store it into variable data
              Serial.println(data);        //Print Value inside data in Serial monitor
              //Serial.print("New data\n");        //New line 
              //Serial.write(data);
              delay (100);
              if(data == '1') 
              {          //Checks whether value of data is equal to 1 
                digitalWrite(7, HIGH);
              
                Serial.println("Red");
                  delay (1000);
                digitalWrite(7, LOW);
              }
               
             else if(data == '2')       
              {
                digitalWrite(6, HIGH);
                Serial.println("Yellow");
              delay (1000);
              digitalWrite(6, LOW);
              }
          
              else if(data == '3')       
              {
              digitalWrite(5, HIGH);
               Serial.println("Green");
              delay (1000);
              digitalWrite(5, LOW);
              }
          
              else
               {
                digitalWrite(7, LOW);
                digitalWrite(6, LOW);
                digitalWrite(5, LOW);
          
               }

           
  }                            
 
}//Loop
