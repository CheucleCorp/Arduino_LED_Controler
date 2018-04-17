#include "Arduino.h"
#include "action.h"

/*
 * Console Like
 *
 * This a command line imitation for Arduino. 
 * It receive data from the computer to the board, and display it.
 * 
 * Maximum 64 bytes buffer.
 * 
 * LedControl Version : Using your keyboard, you can now control a Led. 
 * 
 * Blink Update : You can now blick a Led and choose the blinking speed
 * 
 * Pin Update : You can now choose the output pin (default : pin 13)
 * 
 */


int LED = 13; // Default output 

void setup()                    // run once, when the sketch starts
{
  for(int i=0; i<14 ; i++) {
    pinMode(i,OUTPUT);
  }
  //pinMode(13,OUTPUT);
  Serial.begin(9600);           // set up Serial library at 9600 bps
  // Welcome Text
  Serial.println("**********************************************");
  Serial.println("*    Welcome in Console Like 64B edition     *");
  Serial.println("* Created on 04/04/2018 by Alexandre CHEUCLE *");
  Serial.println("**********************************************");
  Serial.println("**********************************************");
  Serial.println("*                User's guide                *");
  Serial.println("* 1: Led On      0: Led Off      2: Blink On *");
  Serial.println("*               3 : Pin choose               *");
  Serial.println("**********************************************");
  
}

void loop()                       // run over and over again
{
    
    String stringOne;
  while(Serial.available() > 0){ // while something in the buffer /!\ The maximum size of the buffer is 64 characters
     char incomingByte= Serial.read(); // read the buffer content
     stringOne.concat(incomingByte); // concat all the character in one string
  }
  Serial.println(stringOne);
  if (stringOne != 0) { //print only if the string is no null (avoid automatic scroll)
    
    if (stringOne[0] == '1') {
      Serial.println("LED on");
      switchOn(LED);
    }
    if (stringOne[0] == '0') {
      Serial.println("LED off");
      switchOff(LED);
    }
    if (stringOne[0] == '2') {
      Serial.println("Blink On");
      Serial.println("Choose the blink delay (in ms)");
      //Serial.flush();
      while (Serial.available() <= 0) {
      }
      String stringTwo;
      while(Serial.available() > 0) { // while something in the buffer /!\ The maximum size of the buffer is 64 characters
       char incomingByte2= Serial.read(); // read the buffer content
       stringTwo.concat(incomingByte2); // concat all the character in one string
       delay(500);
      }
      Serial.println(stringTwo);
      Serial.flush();
      
       if (stringTwo != 0) {
        int blinkDelay = stringTwo.toInt();
        //Serial.println(
        while (Serial.available() <= 0) {
          blink(LED, blinkDelay);
        }
       }
    }
   if (stringOne[0] == '3') {
      int newPin = stringOne.toInt() -300;
       Serial.println(newPin);
       LED = newPin;
      Serial.println("Changement LED : indiquez le nouveau port");
      switchOn(LED);
      /*while (Serial.available() <= 0) {
      }
      String stringThree;
      while(Serial.available() > 0) { // while something in the buffer /!\ The maximum size of the buffer is 64 characters
       char incomingByte3= Serial.read(); // read the buffer content
       stringThree.concat(incomingByte3); // concat all the character in one string
       delay(500);
      }
      Serial.flush();
      
       if (stringThree != 0) {
        int newPin = stringThree.toInt();
          LED = newPin;
          Serial.println("New pin set");
       }*/
       
  } 
  }  
  delay(2000);
}

