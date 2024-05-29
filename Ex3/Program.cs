using Ex2;
using Ex3;

class Program
{
    static void Main(string[] args)
    {
        Vertice v1 = new Vertice(0, 0);
        Vertice v2 = new Vertice(2, 0);
        Vertice v3 = new Vertice(1, 2);

        Vertice v4 = new Vertice(0, 0);
        Vertice v5 = new Vertice(1, Math.Sqrt(3));
        Vertice v6 = new Vertice(2, 0);

        Vertice v7 = new Vertice(0, 0);
        Vertice v8 = new Vertice(2, 0);
        Vertice v9 = new Vertice(3, 4);

        try
        {
            Triangulo t1 = new Triangulo(v1, v2, v3);
            Triangulo t2 = new Triangulo(v4, v5, v6);
            Triangulo t3 = new Triangulo(v7, v8, v9);

            Console.WriteLine($"Perímetro: {t1.Perimetro}");
            Console.WriteLine($"Área: {t1.Area}");
            Console.WriteLine($"Tipo: {t1.Tipo}");
            Console.WriteLine();

            Console.WriteLine($"Perímetro: {t2.Perimetro}");
            Console.WriteLine($"Área: {t2.Area}");
            Console.WriteLine($"Tipo: {t2.Tipo}");
            Console.WriteLine();

            Console.WriteLine($"Perímetro: {t3.Perimetro}");
            Console.WriteLine($"Área: {t3.Area}");
            Console.WriteLine($"Tipo: {t3.Tipo}");
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}