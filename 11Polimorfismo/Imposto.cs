using System;

class Imposto
{
    //Metodos//
    public virtual void valeAlimentacao(double salario)
    {
        System.Console.WriteLine("Desconto padrão de VA R$: "+(salario * 0.1));
    }
    public virtual void valeTransporte(double salario) //VIRTUAL permite que o valor desse metodo seja alterado por alguma classe herdeira.
    {
        System.Console.WriteLine("Desconto padrão VT de R$"+(salario*0.06));
    }
}