using Ex5;
using System.Collections.ObjectModel;

namespace Ex6;

public class ListaIntervalo
{
    private readonly List<Intervalo> intervalos = new List<Intervalo>();

    public void Add(Intervalo novoIntervalo)
    {
        if (intervalos.Any(i => i.TemIntersecao(novoIntervalo)))
        {
            throw new InvalidOperationException("Não é possível adicionar um intervalo que tem interseção com um intervalo existente.");
        }
        intervalos.Add(novoIntervalo);
        intervalos.Sort((i1, i2) => i1.DataHoraInicial.CompareTo(i2.DataHoraInicial));
    }

    public ReadOnlyCollection<Intervalo> Intervalos => intervalos.AsReadOnly();
}
