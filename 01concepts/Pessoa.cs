using System;


class Pessoa
{
    //Atributos;;
    public string nome;
    public int idade;
    //Metodos;;
    public void mensagem()
    {
        System.Console.WriteLine("Olá "+nome+" você tem "+idade+" anos");
    }
}