#include <math.h>

int sinal1 = 4;
int sinal2 = 13;
int gate = 2;

int pwm, pwm2;
float wt=0;
float w = 377;
float vm = 0.8;
float vda, vdb;
float T= 0;

void setup() {
  // put your setup code here, to run once:
TCCR0B=(TCCR0B & 0b11111000)| 0x02;//altera a frequência do temporizador
Serial.begin(9600);   //habilita o uso da porta serial
pinMode(sinal1, OUTPUT);
pinMode(sinal2, OUTPUT);
attachInterrupt(digitalPinToInterrupt(gate),gerador, RISING); // habilita o uso da interrupção
}

void loop() {
  // put your main code here, to run repeatedly:

}

void gerador(){
  // Aqui são realizados os cálculos para gerar uma senóide a partir da onda quadrada
  
 if (wt  >= 6.28)
 {
   wt =0;
 }
else 
{
 wt = wt + T*w;  
}
// O sinal é deslocado para posição 128(+/- metade de 256) para ser centralizado e assim poder gerar os semiciclos negativos e positivos sem ser ceifada

 vda = vm*sin(wt);
 pwm = 128+ (int)128*vda;  
 analogWrite(sinal1,pwm);
 
// Gerando uma segunda senóide defasada de 120º em relação a primeira vda
 vdb = vm*sin(wt+2.09);
 pwm2 = 128+ (int)128*vdb;
 analogWrite(sinal2,pwm2);
 
 
 Serial.println(pwm2);

 /*
if (T==0){
  digitalWrite(sinal1,HIGH);
  T=1;
}
else{
 digitalWrite(sinal1,LOW);
 T=0;
}
 */
}
