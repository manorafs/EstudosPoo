using System;

class Aluno
{
    //Atributos
    private double Nota1,Nota2;
    //apenas a classe ALUNO (aluno.cs) terá acesso a Nota1 e Nota2.

    //Média

    private double media()
    {
        return (Nota1+Nota2)/2;
    }

    //Mensagem
    public void mensagem()
    {
        System.Console.WriteLine("Insira a primeira nota");
        Nota1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Insira a segunda nota");
        Nota2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("A média é: "+media());
    }
}
