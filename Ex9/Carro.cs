namespace Ex9;

public class Carro
{
    private string _placa;
    private string _modelo;
    private Motor _motor;

    public Carro(string placa, string modelo, Motor motor)
    {
        if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(modelo))
        {
            throw new ArgumentException("Placa e modelo são obrigatórios.");
        }
        Placa = placa;
        Modelo = modelo;
        MotorCarro = motor;
    }

    public string Placa
    {
        get { return _placa; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Placa é obrigatória.");
            }
            _placa = value;
        }
    }

    public string Modelo
    {
        get { return _modelo; }
        private set 
        { 
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Modelo é obrigatório.");
            }
            _modelo = value; 
        }
    }

    public Motor MotorCarro
    {
        get { return _motor; }
        private set
        { 
            if (value == null)
            {
                throw new ArgumentNullException("O carro não pode ficar sem motor!");
            }
            if (_motor != null)
            {
                _motor.RemoverDoCarro();
            }
            value.InstalarMotor(this);
            _motor = value;
        }
    }

    public void TrocarMotor(Motor novoMotor)
    {
        MotorCarro = novoMotor;
    }

    public double CalcularVelocidadeMaxima()
    {
        if (_motor.Cilindrada <= 1.0)
        {
            return 140.0;
        }
        else if (_motor.Cilindrada <= 1.6)
        {
            return 160.0;
        }
        else if (_motor.Cilindrada <= 2.0)
        {
            return 180.0;
        }
        else
        {
            return 220.0;
        }
    }
}
