using System;

class Pessoa
{
    //atributo
    private string nome = "Tati";
    //construtor
    public Pessoa(string nome)
    {
        System.Console.WriteLine(nome);
        System.Console.WriteLine(this.nome);
        //this sempre ligará o atributo da classe ao seu método.
    }
}