using System;

class Aluno
{
    //Atributos
    public string nome;
    public double Nota1, Nota2;

    //Metodo média
    public double media()
    {
        return (Nota1+Nota2)/2;
    }
    //Metodo situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado!";

    }

    //Metodo mensagem

    public void mensagem()
    {
        // obtendo a média
        double obterMedia = media();

        string obterSituacao = situacao(obterMedia);

        System.Console.WriteLine(nome+" está "+obterSituacao+" Com uma média de: "+obterMedia);
    }

}