#include <math.h>

// Neste código são testados os três sensores(corrente, tensão, velocidade) funcionando juntos.

int sensor = A0;
int sensor2 = A1;

int dados,i;
int dados2,j;
 

int medida=0;
int medida2=0;

int cont=0;
int cont2=0;


int vetor[830];
int vetor1[830];

int gate = 20;

////////////////////////////////////////////////////////////////////////
volatile int long counterAB = 0;
volatile int  laps = 0;
uint8_t dir = 0;
int soma=0;
int voltas;
int deltat=0;
int tempref=0, rpm=0;
//////////////////////////////////////////////////////////////////////////


void setup() {
  // put your setup code here, to run once:
attachInterrupt(digitalPinToInterrupt(gate),gerador, CHANGE);
Serial.begin(9600);
pinMode(sensor,INPUT);

////////////
 // AttachInterrupt0, digital Pin 2, Sinal A
  // Ativa interrupção em qualquer mudança do sinal
  attachInterrupt(digitalPinToInterrupt(2), pinoa, CHANGE);
 
  // AttachInterrupt1, digital pin 3, Sinal B
  // Ativa interrupção em qualquer mudança do sinal
  attachInterrupt(digitalPinToInterrupt(3), pinob, CHANGE);

  //AttachInterrupt4, digital pin 19, Sinal Z
  attachInterrupt(digitalPinToInterrupt(19), volta, RISING);
////////  
}


void loop() {
  // put your main code here, to run repeatedly:

if (medida > 829){
 noInterrupts();
  for (i=0; i<=829; i++){
//Serial.print(vetor[i]);
//Serial.println("corrente");
//Serial.print(vetor1[i]);
//Serial.println("Tensão");
  }  
 medida=0;
  }
else
   {
   interrupts();
   }

Serial.print("Número de voltas: ");
Serial.println(laps);

}

void gerador(){

dados=analogRead(sensor);
dados2= analogRead(sensor2);
medida = medida +1;
cont++;

if (cont <= 831){

   vetor[cont] = dados;
   vetor1[cont] = dados2;
}
else
{
  cont=0;
}

}

// AttachInterrupt0, digital Pin 2, Sinal A - Qualquer mudança de borda (CHANGE)
void pinoa() {

 
  // Determina qual o sentido de giro do encoder para o contador de voltas
  if (digitalRead(3) == LOW) {
    dir = 1;
  }
  else {
    dir = 0;
  }
 
  // Incrementa ou decrementa o contador de acordo com a condição do sinal no canal B
  if (digitalRead(3) == HIGH && digitalRead(2) == LOW) {
    counterAB ++;
  }
  else {
    counterAB --;
  }
 
  if (digitalRead(3) == LOW && digitalRead(2) == HIGH) {
    counterAB ++;
  }
  else {
    counterAB --;
  }
 
}




// AttachInterrupt1, digital Pin 3, Sinal B - Qualquer mudança de borda (CHANGE)
void pinob() {

  // Determina qual o sentido de giro do encoder para o contador de voltas
  if (digitalRead(2) == HIGH) {
    dir = 1;
  }
  else {
    dir = 0;
  }
  // Incrementa ou decrementa o contador de acordo com a condição do sinal no canal A
  if (digitalRead(2) == LOW && digitalRead(3) == HIGH) {
    counterAB --;
  }
  else {
    counterAB ++;
  }
 
  if (digitalRead(2) == HIGH && digitalRead(3) == LOW) {
    counterAB --;
  }
  else {
    counterAB ++;
  }
}

// AttachInterrupt4, digital Pin 19, Sinal Z
// Conta numero de voltas do Disco do encoder
void volta() {
 
  if (dir) {
    laps ++;
  }
  else {
    laps --;
  }
}
