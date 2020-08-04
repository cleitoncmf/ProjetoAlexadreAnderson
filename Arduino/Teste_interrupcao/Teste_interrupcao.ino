
int led = 8;
int botao = 20;
int estado = 0;

void teste();

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600); // Habilita o uso da porta serial
pinMode(led,OUTPUT);
attachInterrupt(digitalPinToInterrupt(botao), teste, CHANGE); // Habilita o usa da interrupção
}

void loop() {
  // put your main code here, to run repeatedly:

}

void teste (){
  
  // Toda vez que a interrupção é acionada o estado do led é alterado
  
 if ( estado ==1){
digitalWrite(led,HIGH);
estado=0;
}
else{
  digitalWrite(led,LOW);
  estado=1;
}
Serial.println(estado);
}
