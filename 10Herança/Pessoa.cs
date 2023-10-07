using System;

class Pessoa
{
    //atributo
    protected string nome;
    protected int idade;

    //metodo

    protected void mensagemPessoa()
    {
        System.Console.WriteLine("Nome: "+nome);
        System.Console.WriteLine("Idade: "+idade);
    }
}