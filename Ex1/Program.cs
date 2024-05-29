using Ex1;
using System.Linq.Expressions;

class Program()
{
    static void Main(string[] args)
    {
        try
        {
            Piramide piramide = new Piramide(4);
            piramide.Desenha();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}