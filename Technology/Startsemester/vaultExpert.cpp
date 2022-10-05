/**
 * Rich shield example
 * Adapted from Rich Shield Example Code
 * Fontys University of Applied Science
 * Name: RunLed
 * Date: 01 July 2019
 * Author: Jaap Geurts
 * Version 1.0
 */
#include <Arduino.h>
#include <Display.h>
 
const int buttonPin1 = 8;
const int buttonPin2 = 9;     // the number of the pushbutton pin
//const int ledPin_BLUE =  6;
const int ledPin_RED =  4;  
const int ledPin_GREEN =  5;   // the number of the LED pin
 
int buttonState1 = 0;  
int buttonState2 = 0;
int lastButtonState1 = 0;  
int lastButtonState2 = 0;
 
int count = 0;
String message;
 
int bounce = 50;
int ledDelay = 300;
 
const int PIN_POTMETER = 14;
const int MAX_ANGLE = 9;
 
String testcode = "1111";
 
int arrayLed[] = {0, 0, 0, 0};
int passcode[] = {0, 0, 0, 0};
 
int get_knob_angle()
{
    int sensor_value = analogRead(PIN_POTMETER);
    int angle;
    // map is an Arduino library function.
    // it maps one range to another range.
    angle = map(sensor_value, 0, 1009, 0, MAX_ANGLE);
 
    return angle;
}
 
void printArray() {
 
   if (passcode[0] == arrayLed[0] && passcode[1] == arrayLed[1] && passcode[2] == arrayLed[2] && passcode[3] == arrayLed[3])  {
         Serial.println("Pincode correct");
         digitalWrite(ledPin_GREEN, HIGH);
         digitalWrite(ledPin_RED, LOW);
         delay(5000);
         digitalWrite(ledPin_GREEN, LOW);
         digitalWrite(ledPin_RED, HIGH);
      }
 
      else if (count >= 4){
         Serial.println("Error, Pincode incorrect!");
         for (int i = 0; i < 5; i++)
         {
            digitalWrite(ledPin_RED, LOW);
            delay(ledDelay);
            digitalWrite(ledPin_RED, HIGH);
            delay(ledDelay);
         }
         
         
      }
 
   if (count >= 4){
      arrayLed[0] = 0;
      arrayLed[1] = 0;
      arrayLed[2] = 0;
      arrayLed[3] = 0;
 
     
      count = 0;
   }
 
   for (int i = 0; i < 4; i++)
   {
      Serial.print("arrayLed: ");
      Serial.print(arrayLed[i]);
      Serial.print(" Passcode: ");
      Serial.println(passcode[i]);
 
   }
   Serial.print("Count is: ");
   Serial.println(count);
   Serial.println("-----------");
   
}
void buttonPress1 () {
     if (lastButtonState1 != buttonState1) {
      if (buttonState1 == LOW){
            int angle;
            angle = get_knob_angle();
            arrayLed[count] = angle;
            //Display.showCharAt(count, angle);
            count++;
            printArray();
           
         }
         delay(bounce);
   }
      lastButtonState1 = buttonState1;
}
 
 
void buttonPress2 () {
   if (lastButtonState2 != buttonState2) {
      if (buttonState2 == LOW){
            int angle;
            angle = get_knob_angle();
            arrayLed[count] = angle;
            //Display.showCharAt(count, angle);
            count++;
            printArray();
           
         }
         delay(bounce);
   }
      lastButtonState2 = buttonState2;
}
 
 
void start(){
 
    char received = Serial.read();
   
 
    if (received == '\n') // Message is finished, so process message.
    {
      Serial.println("New pincode: " + message); // Only for debugging.
      // TODO: Below fill in your own message handling.
     
      for (int i = 0; i < 4; i++)
      {
         passcode[i] = message[i] - 48; // passcode has to be in range of 1 > 9, without -48 you would get the ASCII character
      }
     
      message = message; // Message is processed, so clear message.
    }
    else  // Message is not finished yet, so add the received character to message.
    {
      message += received;
    }
  }
 
 
void setup(){
 
    pinMode(ledPin_RED, OUTPUT);
    pinMode(ledPin_GREEN, OUTPUT);
    //pinMode(ledPin_BLUE, OUTPUT);
     
    pinMode(buttonPin1, INPUT_PULLUP);
    pinMode(buttonPin2, INPUT_PULLUP);
 
    pinMode(PIN_POTMETER,INPUT);
 
    Serial.begin(9600);
    Serial.println("Enter pincode: ");
 
    Display.show(0000);
   
}
 
 
 
void loop(){
 
   buttonState1 = digitalRead(buttonPin1);
   buttonState2 = digitalRead(buttonPin2);
   
   digitalWrite(ledPin_RED,  HIGH);
   
   
   if (Serial.available() > 0) {
      start();
   }
 
   
    int angle;
    angle = get_knob_angle();
    Display.show(angle);
    buttonPress1();
    buttonPress2();
    delay(bounce);
 
}
