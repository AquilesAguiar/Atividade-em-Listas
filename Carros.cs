//Criandop a Class Carro
class Carro {
  
  //Definindo a Marca e o seu GET
  string marca;
  public string getMarca(){
    return marca;
  }
 
  //Definindo o Consumo e o seu GET
  double consumo_litro;
  public double getConsumo(){
    return consumo_litro;
  }

  //Construtor Completo
  public Carro (string m, double c){
    marca = m;
    consumo_litro = c;
  }

}

  

  
    
  
