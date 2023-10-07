namespace _05ModificadoresDeAcesso;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        p.nome = "Mouse";

        //observa-se que apenas p.nome é exibido pois foi definido como public.
    }
}
