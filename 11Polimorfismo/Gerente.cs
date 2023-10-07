using System;

class Gerente : Imposto
{
    //metodo
    public override void valeAlimentacao(double salario)
    {
        System.Console.WriteLine("Desconto gerente de VA R$: "+(salario * 0.15));
    }
}