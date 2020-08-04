#include <math.h>

// Programa que gera três ondas senoidais defasadas de 120º utilizando PWM 

//PWM normal
int n_onda1 = 6;
int n_onda2 = 7;
int n_onda3 = 8;

//PWM invertido
int i_onda1 = 2;
int i_onda2 = 3;
int i_onda3 = 5;

float vda,vdb,vdc;

int ka, kb, kc;

int gate = 20;
 
float wt=0;
float w = 377;
float vm = 0.8;
float T;
float f = 5800;

void setup() {
  // put your setup code here, to run once:
TCCR3B=(TCCR3B & 0b11111000)| 0x02;//altera a frequência do temporizador
TCCR4B=(TCCR4B & 0b11111000)| 0x02;
TCCR3A = 0b01010101;//inverte a saída pwm
pinMode( n_onda1, OUTPUT); 
pinMode( n_onda2, OUTPUT);
pinMode( n_onda3, OUTPUT);
pinMode( i_onda1, OUTPUT);
pinMode( i_onda2, OUTPUT);
pinMode( i_onda3, OUTPUT);
attachInterrupt(digitalPinToInterrupt(gate),gerador, CHANGE);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:

}

void gerador(){
  T = 1/f;
  
 if (wt > 6.28)
 {
   wt =0;
 }
else 
{
 wt = wt + T*w;  
}


vda = vm*sin(wt);
ka= 128+(int)128*vda;
analogWrite(n_onda1,ka);

analogWrite(i_onda1,ka);



vdb = vm* sin(wt+2.09);
kb = 128+(int)128*vdb;
analogWrite(n_onda2,kb);

analogWrite(i_onda2,kb);



vdc = vm* sin(wt+4.19);
kc = 128+(int)128*vdc;
analogWrite(n_onda3,kc);

analogWrite(i_onda3,kc);

Serial.println(kb);


}
