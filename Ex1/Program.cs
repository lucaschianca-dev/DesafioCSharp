namespace Ex1;

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