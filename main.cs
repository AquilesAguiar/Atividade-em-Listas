using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    //definindo alguma Variaveis
    string continuar="s", marca;
    double consumo;
    //Instaciando a Classe Carro
    Carro NovoAut = new Carro("TESTE", 0);
    
    //Instaciando Lista
    List<Carro> listaCarros = new List<Carro>();

    //Repetição Para Adicionar Itens a Lista
    while (continuar=="s"){
      
      Console.Write("Insira a Marca do Carro>>");
      marca = Console.ReadLine();

      Console.Write("Km do Carro>>");
      consumo = double.Parse(Console.ReadLine());

      //Adicionando Itens a Lista
      NovoAut = new Carro(marca, consumo);
      listaCarros.Add(NovoAut);

      Console.Write("Deseja Continuar? s/n >>");
      continuar = Console.ReadLine();
    }
    
    //Define o Menor consumo da lista ni index 0
    Carro menor_consumo = listaCarros[0];


    //Definir o Carro com o Menor consumo na lista
    for(int i = 1;i < listaCarros.Count ;i++){
      if(listaCarros[i].getConsumo() > menor_consumo.getConsumo())
      menor_consumo = listaCarros[i];
    }

    Console.WriteLine($"O modelo do carro mais econômico {menor_consumo.getMarca()}");

   Console.WriteLine($"O consumo do carro mais econômico {menor_consumo.getConsumo()}");

    // Calcula A quantidade de Litros e o valor em Uma determina distancia

    for(int i = 0 ; i < listaCarros.Count; i++){
      Console.WriteLine($"{listaCarros[i].getMarca()}");

      Console.WriteLine($"Listros Gastos em 1000 KM: {1000/listaCarros[i].getConsumo()}");

      Console.WriteLine($"Valor gasto ao percorrer 1000 KM:{(1000/listaCarros[i].getConsumo())*4.89}");    
    }

  }
}