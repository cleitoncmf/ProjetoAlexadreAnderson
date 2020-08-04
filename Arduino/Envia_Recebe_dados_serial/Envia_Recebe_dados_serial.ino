
int valor;
int vet[255];
int i = 0;

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600); // inicializa a porta serial
}

void loop() {
while (true){
{
  // put your main code here, to run repeatedly:
   if (Serial.available()>0){ // monitora a porta serial a todo instante
    valor = Serial.read(); // a variavel valor recebe o que foi colocado na porta serial
 }

if (valor == '1'){
    Serial.println("Motor Ligado!");
}

if (valor == '2'){
    Serial.println("Motor Desligado!");
}

 
if (valor == '3'){
  Serial.println("Corrente Fase A");
  for (i=0; i<255; i++){
    vet[i] = i+1;
    Serial.println(vet[i]);
    //Serial.print("\t");
  }
}

if (valor == '4'){
  Serial.println("Corrente Fase B");
  for (i=0; i<255; i++){
    vet[i] = i+1;
    Serial.println(vet[i]);
    //Serial.print("\t");
  }
}

if (valor == '5'){
  Serial.println("Corrente Fase C");
  for (i=0; i<255; i++){
    vet[i] = i+1;
    Serial.println(vet[i]);
    //Serial.print("\t");
  }
}

if (valor == '6'){
  Serial.println("Tensao Fase A");
  for (i=0; i<255; i++){
    vet[i] = i+1;
    Serial.println(vet[i]);
    //Serial.print("\t");
  }
}

if (valor == '7'){
  Serial.println("Tensao Fase B");
  for (i=0; i<255; i++){
    vet[i] = i+1;
    Serial.println(vet[i]);
    //Serial.print("\t");
  }
}


if (valor == '8'){
  Serial.println("Tensao Fase C");
  for (i=0; i<255; i++){
    vet[i] = i+1;
    Serial.println(vet[i]);
    //Serial.print("\t");
  }
}


}
valor = 0;
}
}
