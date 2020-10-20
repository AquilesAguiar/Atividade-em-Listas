using System.Collections.Generic;

class listaCarro{
  public List<string> lista_Carros = new List<string>();
  public List<double> lista_Consumo = new List<double>();

  public lista_Carro(){
    lista_Carro.Add("Ferrari");
    lista_Consumo.Add(2000);

    lista_Carro.Add("Porsche");
    lista_Consumo.Add(37262);

    lista_Carro.Add("corsa");
    lista_Consumo.Add(100000);

    lista_Carro.Add("Celta");
    lista_Consumo.Add(435287);
  }
}