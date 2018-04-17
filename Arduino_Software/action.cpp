#include "action.h"
#include "Arduino.h"

void switchOn(int pin) {
  digitalWrite(pin, HIGH);
}

void switchOff(int pin) {
  digitalWrite(pin, LOW);
}

void blink(int pin, int blinkDelay) {
  
    digitalWrite(pin, HIGH);
    //Serial.println("HIGH");
    delay(blinkDelay);
    //Serial.println("LOW");
    digitalWrite(pin, LOW);
    delay(blinkDelay);
}


