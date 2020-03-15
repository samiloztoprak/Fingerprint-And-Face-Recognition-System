#include <Adafruit_Fingerprint.h>
#include <SoftwareSerial.h>
SoftwareSerial mySerial(2, 3);

Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

String inputString = "";         // a String to hold incoming data
bool stringComplete = false;  // whether the string is complete

bool control=false;
String gelenVeri="";
uint8_t id;
void setup()
{
    // reserve 200 bytes for the inputString:
  inputString.reserve(200);
  
Serial.begin(300);
while (!Serial); // For Yun/Leo/Micro/Zero/...
delay(100);
//Serial.println("Parmak ızı  okutmak ıcın Okut=>Okut komutunu  gırınız");
//Serial.println("Parmak ızı kaydı ıcın Kayit=>Kayit komutunu  gırınız");
//Serial.println("Parmak ızı sılmek ıcın Sılme=>Sil komutunu gırınız");
finger.begin(57600);
 
if (finger.verifyPassword()) {
Serial.println("Parmak izi sensörü tespit edildi!");
} else {
Serial.println("Parmak izi sensörü tespit edilemedi :(");
while (1) { delay(1); }
}
 
finger.getTemplateCount();
Serial.print("sensör içeriği "); Serial.print(finger.templateCount); Serial.println(" Parmak izleri");
Serial.println("Parmak tespit ediliyor...");

}
void loop() // run over and over again
{
  if(Serial.available()){
    gelenVeri=Serial.readStringUntil('\n');
    if(gelenVeri=="Okut"){
          control=true;
    }
     if(gelenVeri=="Sil"){
      Serial.println("Please type in the ID # (from 1 to 127) you want to delete...");
      uint8_t id = readnumber();
      if (id == 0) {// ID #0 not allowed, try again!
        return;
      }
      Serial.print("Deleting ID #");
      Serial.println(id);
      deleteFingerprint(id);
    
    }
      if(gelenVeri=="Kayit"){
       Serial.println("Ready to enroll a fingerprint!");
       Serial.println("Please type in the ID # (from 1 to 127) you want to save this finger as...");
       id = readnumber();
       if (id == 0) {// ID #0 not allowed, try again!
        return;
        }
        Serial.print("Enrolling ID #");
        Serial.println(id);
        while (!  getFingerprintEnroll() );
        
        
      }
  }
   if(control==true){
      Serial.println("-1");
      gelenVeri=Serial.readStringUntil('\n');
      int getFingerId=getFingerprintIDez();
      delay(50); //don't ned to run this at full speed.
      if(getFingerId!=-1){
        control=false;
        }
    }
     if (stringComplete) {
    Serial.println(inputString);
    // clear the string:
    inputString = "";
    stringComplete = false;
  }
  }
