using System;

class MainClass {
  public static void Main (string[] args) {
   listaCarro informacoes = new listaCarro();

   string carroEco = '';
   double contadorEco = informacoes.lista_Consumo[0];
  
   for(int x = 0;x > informacoes.lista_Carro;x++){
     if(informacoes.lista_Consumo[x] > contadorEco ){
       contadorEco = informacoes.lista_Consumo[x];
       carroEco = informacoes.lista_Carro[x];
     }
   }

   Console.WriteLine($"O modelo do carro mais econômico {carroEco}");

   Console.WriteLine($"O consumo do carro mais econômico {contadorEco}");

   for (int x = 0; i < informacoes.lista_Carro ;x++ ){
     
   }
  

  }
}