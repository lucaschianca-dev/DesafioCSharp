namespace Ex2;

class Program
{
    static void Main(string[] args)
    {
        Vertice v1 = new Vertice(0, 0);
        Vertice v2 = new Vertice(3, 4);

        Console.WriteLine($"Distância entre v1 e v2: {v1.Distancia(v2)}");

        v1.Move(3, 4);
        Console.WriteLine($"v1 movido para: ({v1.X}, {v1.Y})");

        Console.WriteLine($"v1 e v2 são iguais? {v1.Equals(v2)}");
    }
}