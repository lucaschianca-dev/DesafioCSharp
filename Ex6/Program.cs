using Ex5;
using Ex6;

public class Program
{
    static void Main(string[] args)
    {
        ListaIntervalo lista = new ListaIntervalo();

        Intervalo intervalo1 = new Intervalo(new DateTime(2024, 5, 29, 15, 0, 0), new DateTime(2024, 5, 29, 17, 0, 0));
        Intervalo intervalo2 = new Intervalo(new DateTime(2024, 5, 29, 8, 0, 0), new DateTime(2024, 5, 29, 14, 0, 0));

        lista.Add(intervalo1);
        lista.Add(intervalo2);

        foreach (var intervalo in lista.Intervalos)
        {
            Console.WriteLine($"Intervalo: {intervalo.DataHoraInicial} - {intervalo.DataHoraFinal}");
        }
    }
}