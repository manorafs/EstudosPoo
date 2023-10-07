using System;

class Pessoa
{
        //METODO 01
        public void apresentar()
        {
            System.Console.WriteLine("Olá!!");
        }

        //METODO 02
         public void apresentar(string nome)
        {
            System.Console.WriteLine("Olá"+nome);
        }

        //METODO 03
         public void apresentar(string nome, int idade)
        {
            System.Console.WriteLine("Olá "+nome+"Você tem "+idade);
            
        }
}   
