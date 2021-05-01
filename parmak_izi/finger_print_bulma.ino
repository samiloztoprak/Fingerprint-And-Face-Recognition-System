uint8_t getFingerprintID() {
uint8_t p = finger.getImage();
switch (p) {
case FINGERPRINT_OK:
Serial.println("Resim Çekildi");
break;
case FINGERPRINT_NOFINGER:
Serial.println("Parmak izi yok");
return p;
case FINGERPRINT_PACKETRECIEVEERR:
Serial.println("İletişim hatası");
return p;
case FINGERPRINT_IMAGEFAIL:
Serial.println("Görüntüleme hatası");
return p;
default:
Serial.println("Bilinmeyen hata");
return p;
}
 
// OK success!
 
p = finger.image2Tz();
switch (p) {
case FINGERPRINT_OK:
Serial.println("işlenmiş görüntü");
break;
case FINGERPRINT_IMAGEMESS:
Serial.println("Çok dağınık görüntü");
return p;
case FINGERPRINT_PACKETRECIEVEERR:
Serial.println("İletişim hatası");
return p;
case FINGERPRINT_FEATUREFAIL:
Serial.println("Parmak izi özellikleri bulunamadı");
return p;
case FINGERPRINT_INVALIDIMAGE:
Serial.println("Parmak izi özellikleri bulunamadı");
return p;
default:
Serial.println("Bilinmeyen hata");
return p;
}
 
// OK converted!
p = finger.fingerFastSearch();
if (p == FINGERPRINT_OK) {
Serial.println("Bir parmak izi ile eşleşti!");
} else if (p == FINGERPRINT_PACKETRECIEVEERR) {
Serial.println("İletişim hatası");
return p;
} else if (p == FINGERPRINT_NOTFOUND) {
Serial.println("Bir eşleşme bulunamadı");
return p;
} else {
Serial.println("Bilinmeyen hata");
return p;
}
 
// found a match!
//Serial.print("Bulunan Kimlik #"); 
Serial.print(finger.fingerID);
//Serial.print(" with confidence of "); Serial.println(finger.confidence);
 
return finger.fingerID;
}
 
// returns -1 if failed, otherwise returns ID #
int getFingerprintIDez() {
uint8_t p = finger.getImage();
if (p != FINGERPRINT_OK) return -1;
 
p = finger.image2Tz();
if (p != FINGERPRINT_OK) return -1;
 
p = finger.fingerFastSearch();
if (p != FINGERPRINT_OK) return -1;
 
// found a match!
//Serial.print("Bulunan Kimlik#");
Serial.print(finger.fingerID);
//Serial.print(" with confidence of "); Serial.println(finger.confidence);
return finger.fingerID;
}
