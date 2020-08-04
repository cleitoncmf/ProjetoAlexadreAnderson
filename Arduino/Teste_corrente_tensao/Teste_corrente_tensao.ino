#include <math.h>

// Programa para testar o sensor de tensão e corrente ao mesmo tempo. Teste básico, verifica se a medição é realizada e comparar a leitura com o mostrado no osciloscópio.

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



void setup() {
  // put your setup code here, to run once:
attachInterrupt(digitalPinToInterrupt(gate),gerador, CHANGE);
Serial.begin(9600);
pinMode(sensor,INPUT);
}


void loop() {
 
  // Aqui o valor armazenado no vetor e descarregado mostrando esses valores na tela.

if (medida > 829){
 noInterrupts();
  for (i=0; i<=829; i++){
Serial.print(vetor[i]);
Serial.println("corrente");
Serial.print(vetor1[i]);
Serial.println("Tensão");
  }  
 medida=0;
  }
else
   {
   interrupts();
   }

}

void gerador(){
 // O sensor realiza medida e armazena os dados no vetor até uma determinada quantidade. 
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
