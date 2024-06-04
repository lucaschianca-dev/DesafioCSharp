namespace Ex5;

public class Intervalo
{
    public DateTime DataHoraInicial { get; }
    public DateTime DataHoraFinal { get; }

    public Intervalo(DateTime dataHoraInicial, DateTime dataHoraFinal)
    {
        if (dataHoraInicial >= dataHoraFinal)
        {
            throw new ArgumentException("A data/hora inicial deve ser menor que a data/hora final.");
        }

        DataHoraInicial = dataHoraInicial;
        DataHoraFinal = dataHoraFinal;
    }

    public bool TemIntersecao(Intervalo outro)
    {
        if (outro == null) throw new ArgumentNullException(nameof(outro));
        return DataHoraInicial < outro.DataHoraFinal && DataHoraFinal > outro.DataHoraInicial;
    }

    public override bool Equals(object obj)
    {
        if (obj is Intervalo outro)
        {
            return Duracao == outro.Duracao;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Duracao);
    }

    public TimeSpan Duracao => DataHoraFinal - DataHoraInicial;
}