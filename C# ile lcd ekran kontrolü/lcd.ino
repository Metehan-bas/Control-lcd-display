#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27, 16, 2); // LCD adresi ve boyutu

void setup() {
  lcd.begin();           // LCD başlatılır
  lcd.backlight();       // Arka ışık açılır
  lcd.clear();           // Ekran temizlenir
  Serial.begin(9600);    // Seri haberleşme başlatılır
}

void loop() {
  String veri = ""; // Her döngüde sıfırla

  if (Serial.available()) {
    veri = Serial.readString();
    veri.trim();
  }

  if (veri.length() > 0) {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Veri:");
    lcd.setCursor(0, 1);
    lcd.print(veri);

    delay(2000);
    lcd.clear();
  }
}
