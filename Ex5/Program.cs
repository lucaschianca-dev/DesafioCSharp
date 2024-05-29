namespace Ex5;

public class Program
{
    static void Main(string[] args)
    {
        DateTime inicio1 = new DateTime(2024, 5, 29, 12, 0, 0);
        DateTime fim1 = new DateTime(2024, 5, 29, 13, 0, 0);
        Intervalo intervalo1 = new Intervalo(inicio1, fim1);

        DateTime inicio2 = new DateTime(2024, 5, 29, 13, 0, 0);
        DateTime fim2 = new DateTime(2024, 5, 29, 14, 0, 0);
        Intervalo intervalo2 = new Intervalo(inicio2, fim2);

        Console.WriteLine($"Intervalo 1: {intervalo1.DataHoraInicial} - {intervalo1.DataHoraFinal}");
        Console.WriteLine($"Intervalo 2: {intervalo2.DataHoraInicial} - {intervalo2.DataHoraFinal}");

        Console.WriteLine($"Tem interseção: {intervalo1.TemIntersecao(intervalo2)}");
        Console.WriteLine($"Duração do intervalo 1: {intervalo1.Duracao}");
        Console.WriteLine($"Duração do intervalo 2: {intervalo2.Duracao}");

        Console.WriteLine($"Intervalo 1 é igual ao Intervalo 2: {intervalo1.Equals(intervalo2)}");
    }
}