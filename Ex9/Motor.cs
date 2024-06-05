namespace Ex9;

public class Motor
{
    private double _cilindrada;
    private Carro _carroInstalado;

    public Motor(double cilindrada)
    {
        Cilindrada = cilindrada;
    }

    public double Cilindrada
    {
        get { return _cilindrada; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Cilindrada deve ser maior que zero.");
            }
            _cilindrada = value;
        }
    }

    public void InstalarMotor(Carro carro)
    {
        if (_carroInstalado != null && _carroInstalado != carro)
        {
            throw new InvalidOperationException("Este motor já está instalado em outro carro.");
        }
        _carroInstalado = carro;
    }

    public void RemoverDoCarro()
    {
        _carroInstalado = null;
    }
}
