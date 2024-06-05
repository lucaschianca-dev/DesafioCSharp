using Ex9;

class Program
{
    static void Main(string[] args)
    {
        Carro carro = null;
        Motor motor = null;
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Criar um motor");
            Console.WriteLine("2. Criar um carro");
            Console.WriteLine("3. Trocar motor do carro");
            Console.WriteLine("4. Exibir informações do carro");
            Console.WriteLine("5. Sair");
            Console.Write("Selecione uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    motor = CriarMotor();
                    break;

                case "2":
                    carro = CriarCarro(motor);
                    break;

                case "3":
                    if (carro == null)
                    {
                        Console.WriteLine("Crie um carro primeiro.");
                    }
                    else
                    {
                        motor = CriarMotor();
                        carro.TrocarMotor(motor);
                    }
                    break;

                case "4":
                    if (carro == null)
                    {
                        Console.WriteLine("Crie um carro primeiro.");
                    }
                    else
                    {
                        ExibirInformacoesCarro(carro);
                    }
                    break;

                case "5":
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static Motor CriarMotor()
    {
        Console.Write("Digite a cilindrada do motor: ");
        double cilindrada = double.Parse(Console.ReadLine());
        Motor motor = new Motor(cilindrada);
        Console.WriteLine($"Motor de {motor.Cilindrada}cc criado com sucesso.");
        return motor;
    }

    static Carro CriarCarro(Motor motor)
    {
        if (motor == null)
        {
            Console.WriteLine("Crie um motor primeiro.");
            return null;
        }

        Console.Write("Digite a placa do carro: ");
        string placa = Console.ReadLine();
        Console.Write("Digite o modelo do carro: ");
        string modelo = Console.ReadLine();
        Carro carro = new Carro(placa, modelo, motor);
        Console.WriteLine($"Carro {carro.Modelo} com placa {carro.Placa} criado com sucesso.");
        return carro;
    }

    static void ExibirInformacoesCarro(Carro carro)
    {
        Console.WriteLine($"\nCarro: {carro.Modelo}");
        Console.WriteLine($"Placa: {carro.Placa}");
        Console.WriteLine($"Motor: {carro.MotorCarro.Cilindrada}cc");
        Console.WriteLine($"Velocidade máxima: {carro.CalcularVelocidadeMaxima()} km/h");
    }
}