using System;

class Atendente : Imposto
{
    //metodo
    public override void valeAlimentacao(double salario) //override sobrescreve o valor herdado do imposto
    {
        System.Console.WriteLine("Desconto atendente de VA R$: "+(salario * 0.12));
    }
    
}