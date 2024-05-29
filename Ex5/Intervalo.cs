namespace Ex5;

public class Intervalo
{
    public DateTime DataHoraInicial { get; }
    public DateTime DataHoraFinal { get; }

    public Intervalo(DateTime dataHoraInicial, DateTime dataHoraFinal)
    {
        if (dataHoraInicial > dataHoraFinal)
        {
            throw new ArgumentException("A data/hora inicial não pode ser maior que a data/hora final.");
        }

        DataHoraInicial = dataHoraInicial;
        DataHoraFinal = dataHoraFinal;
    }

    public bool TemIntersecao(Intervalo outro)
    {
        return DataHoraInicial < outro.DataHoraFinal && DataHoraFinal > outro.DataHoraInicial;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Intervalo outro = (Intervalo)obj;
        return DataHoraInicial == outro.DataHoraInicial && DataHoraFinal == outro.DataHoraFinal;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(DataHoraInicial, DataHoraFinal);
    }

    public TimeSpan Duracao
    {
        get { return DataHoraFinal - DataHoraInicial; }
    }
}
