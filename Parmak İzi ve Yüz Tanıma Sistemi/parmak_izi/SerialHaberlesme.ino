void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    //char inChar = (char)Serial.read();
    inputString = Serial.readString();

    Serial.println(inputString);
    

  }
}
