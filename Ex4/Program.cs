using Ex2;

namespace Ex4;

class Program
{
    static void Main(string[] args)
    {
        List<Vertice> vertices = new List<Vertice>
            {
                new Vertice(0, 0),
                new Vertice(0, 2),
                new Vertice(1, 0)
            };

        Poligono poligono = new Poligono(vertices);
        Console.WriteLine($"Perímetro do polígono: {poligono.Perimetro()}");
        Console.WriteLine($"Quantidade de vértices: {poligono.QuantidadeDeVertices}");

        Vertice novoVertice = new Vertice(1, 1);
        if (poligono.AddVertice(novoVertice))
        {
            Console.WriteLine("Vértice adicionado com sucesso.");
        }
        else
        {
            Console.WriteLine("Vértice já existe no polígono.");
        }

        Console.WriteLine($"Perímetro do polígono após adicionar novo vértice: {poligono.Perimetro()}");
        Console.WriteLine($"Quantidade de vértices após adicionar novo vértice: {poligono.QuantidadeDeVertices}");

        poligono.RemoveVertice(novoVertice);
        Console.WriteLine($"Perímetro do polígono após remover o vértice: {poligono.Perimetro()}");
        Console.WriteLine($"Quantidade de vértices após remover o vértice: {poligono.QuantidadeDeVertices}");
    }
}