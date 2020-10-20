using System.Collections.Generic;

class listaCarro{
  public List<string> lista_Carros = new List<string>();
  public List<double> lista_Consumo = new List<double>();

  public listaCarro(){
    lista_Carros.Add("Ferrari");
    lista_Consumo.Add(7);

    lista_Carros.Add("Porsche");
    lista_Consumo.Add(9.2);

    lista_Carros.Add("corsa");
    lista_Consumo.Add(10);

    lista_Carros.Add("Celta");
    lista_Consumo.Add(12.4);
  }
}