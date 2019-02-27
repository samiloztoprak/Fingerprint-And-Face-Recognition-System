

int ileripin=10;
int geripin=11;
int sagpin=12;
int solpin=13;
const int butonPin=9;
//int yesil=7;
int kirmizi=8;
int buttonState = 0; 


String seriPortDeger = "";         
boolean okumaTamam = false; 
boolean basla = false; 


 
void setup() {
   pinMode(ileripin, OUTPUT);
   pinMode(geripin, OUTPUT);
   pinMode(sagpin, OUTPUT);
   pinMode(solpin, OUTPUT); 
   pinMode(butonPin, INPUT);
   //pinMode(yesil, OUTPUT); 
   pinMode(kirmizi, OUTPUT); 
   
   digitalWrite(ileripin,0);
   digitalWrite(geripin,0);
   digitalWrite(sagpin,0);
   digitalWrite(solpin,0);
   //digitalWrite(yesil,0);
   digitalWrite(kirmizi,0);
   
   Serial.begin(9600);
} 

void loop() {
  if (digitalRead(butonPin)==HIGH)
     
     {
        if (digitalRead (kirmizi)==HIGH){ digitalWrite(kirmizi,0);
    delay(500);  
    }
       else
       {
       digitalWrite(kirmizi,1);
       delay(500);
       //digitalWrite(yesil,1);
       }
     }
     
   if (digitalRead (kirmizi)==HIGH) 
{   
   if (okumaTamam) {
     
    Serial.println(seriPortDeger); 
    if (seriPortDeger=="2") {
     
      digitalWrite(sagpin, 1);
      delay(75);
      digitalWrite(sagpin, 0);
      
    }
    else if (seriPortDeger=="1") {
      
      digitalWrite(solpin, 1);
      delay(75);
      digitalWrite(solpin, 0);
      
    }
        if (seriPortDeger=="i") {
          
      digitalWrite(ileripin, 1);
      delay(500);
      digitalWrite(ileripin, 0);
      
    }
    else if (seriPortDeger=="g") {
      
      digitalWrite(geripin, 1);
      delay(500);
      digitalWrite(geripin, 0);
      
    }
    if(seriPortDeger=="y")
    {
      digitalWrite(ileripin, 1);
      delay(1500);
      digitalWrite(ileripin, 0);
    }
  
    seriPortDeger = "";//okunan değeri sıfırlar
    okumaTamam = false;
    
     }

}
   
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read(); 
    // add it to the inputString:
    if (inChar == '\n') okumaTamam = true;
    else seriPortDeger += inChar;
  }
}
 
