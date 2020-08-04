
// programa para testar o PWM e testar o PWM reverso. 
int n1 = 2;
int n2 = 3;
int n3 = 5;
int i1 = 6;
int i2 = 7;
int i3 = 8;
int i,j,k;


void setup() {
  
TCCR3B=(TCCR3B & 0b11111000)| 0x02;//altera a frequência do temporizador
TCCR4B=(TCCR4B & 0b11111000)| 0x02;
TCCR3A = 0b01010101; //inverte a saída pwm
Serial.begin(9600);
pinMode(n1,OUTPUT);
pinMode(n2,OUTPUT);
pinMode(n3,OUTPUT);
pinMode(i1,OUTPUT);
pinMode(i2,OUTPUT);
pinMode(i3,OUTPUT);
}

void loop() {
 
analogWrite(n1,25);
analogWrite(n2,25);
analogWrite(n3,25);
analogWrite(i1,25);
analogWrite(i2,25);
analogWrite(i3,25);
}
