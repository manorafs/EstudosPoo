using System;

class Pessoa
{
    //atributos;;
    public double peso, altura;
   
    //método obter imc;;
    public double calcularIMC()
    {
        return peso /(altura*altura);
    }
    //método situação;;
    public string obterIMC()
    {
        double imc = calcularIMC();
        return imc < 18.5 ? "Abaixo do peso" :
        imc < 25 ? "Peso normal" : 
        imc < 30 ? "Acima do peso" : 
        imc < 35 ? "Obesidade I" : 
        imc < 40 ? "Obesidade II" : "Obesidade III";
    }

   
    //método mensagem;;

    public void resultado()
    {
        
        System.Console.WriteLine("Você tem uma altura de: " +altura+" Um peso de: "+peso+"kg. Seu IMC é de: "+calcularIMC()+ "e sua situação está: "+obterIMC());
    }
}