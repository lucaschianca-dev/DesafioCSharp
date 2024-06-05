using Ex8;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string nome = LerNome();
        long cpf = LerCpf(out long cpfLong);
        //data
        String rendaMensal = LerRendaMensal(out float rendaMensalFloat);
        String estadoCivil = LerEstadoCivil();
        String dependentes = LerDependentes();

        Pessoa pessoa = new Pessoa(nome, cpf,/*dataDeNascimento,*/ rendaMensal, estadoCivil, dependentes);

        int comprimentoMaximo = 18;

        Console.WriteLine("=====================================");
        Console.WriteLine("|               DADOS               |");
        Console.WriteLine("=====================================");
        Console.WriteLine($"| Nome:           {pessoa.Nome.PadRight(comprimentoMaximo)}|");
        Console.WriteLine($"| CPF:            {pessoa.Cpf:D11}".PadRight(comprimentoMaximo + 7) + "|");
        // Console.WriteLine($"| Data de Nascimento: {dataDeNascimento:dd/MM/yyyy}".PadRight(comprimentoMaximo) + "|");
        Console.WriteLine($"| Renda Mensal:   R$ {pessoa.RendaMensal}".PadRight(comprimentoMaximo + 7) + "|");
        Console.WriteLine($"| Estado Civil:   {pessoa.EstadoCivil.PadRight(comprimentoMaximo)}|");
        Console.WriteLine($"| Dependentes:    {pessoa.Dependentes.PadRight(comprimentoMaximo)}|");
        Console.WriteLine("=====================================");

        static string LerNome()
        {
            string nome;
            while (true)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                if (ValidaDados.ValidaNome(nome))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("+----------------------------------------------------+");
                Console.WriteLine("  ERRO - O campo deve conter ao menos 5 caracteres!");
                Console.WriteLine("+----------------------------------------------------+");
                Console.WriteLine();
            }
            Console.WriteLine($"Nome digitado: ({nome})");
            Console.WriteLine();
            return nome;
        }

        static long LerCpf(out long cpfLong)
        {
            string cpf;
            while (true)
            {
                Console.WriteLine("Digite o CPF: ");
                cpf = Console.ReadLine();

                if (ValidaDados.ValidaCpf(cpf, out cpfLong))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("+-----------------------+");
                    Console.WriteLine("  ERRO - CPF inválido!");
                    Console.WriteLine("+-----------------------+");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"CPF digitado: ({cpfLong})");
            Console.WriteLine();
            return cpfLong;
        }

        static string LerRendaMensal(out float rendaMensalFloat)
        {
            string rendaMensalStr;
            int beneficio = 550; //<- Usei este atributo para testar se o valor da renda é validado,
                                 //convertido para float corretamente,
                                 //feito os cálculos e retornado como String para ser armazenado na entidade Pessoa.
            while (true)
            {
                Console.Write("Digite a sua renda mensal: R$ ");
                rendaMensalStr = Console.ReadLine();

                if (ValidaDados.ValidaRendaMensal(rendaMensalStr, out rendaMensalFloat))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("+-----------------------------------------------+");
                    Console.WriteLine("  ERRO - Sua renda deve ser maior que R$ 0,00!");
                    Console.WriteLine("+-----------------------------------------------+");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Valor digitado: R$ {rendaMensalStr}");
            Console.WriteLine($"Calculando Benefícios: R$ {rendaMensalFloat += beneficio}");
            Console.WriteLine();
            return rendaMensalFloat.ToString("F2");
        }

        static string LerEstadoCivil()
        {
            string estadoCivil;
            while (true)
            {
                Console.WriteLine("Digite seu estado civil [C - Casado(a) / S - Solteiro(a) / V - Viúvo(a) / D - Divorciado(a)]: ");
                estadoCivil = Console.ReadLine();

                if (ValidaDados.ValidaEstadoCivil(estadoCivil))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("+------------------------------------+");
                    Console.WriteLine("  ERRO - Digite apenas C, S, V ou D!");
                    Console.WriteLine("+------------------------------------+");
                    Console.WriteLine();
                }
            }
            switch (estadoCivil)
            {
                case "C":
                case "c":
                    Console.WriteLine("Regime selecionado: Casado(a)");
                    Console.WriteLine();
                    return estadoCivil.ToUpper();

                case "S":
                case "s":
                    Console.WriteLine("Regime selecionado: Solteiro(a)");
                    Console.WriteLine();
                    return estadoCivil.ToUpper();

                case "V":
                case "v":
                    Console.WriteLine($"Regime selecionado: Viúvo(a)");
                    Console.WriteLine();
                    return estadoCivil.ToUpper();

                case "D":
                case "d":
                    Console.WriteLine("Regime selecionado: Divorciado(a)");
                    Console.WriteLine();
                    return estadoCivil.ToUpper();

                default:
                    Console.WriteLine("Estado civil inválido.");
                    Console.WriteLine();
                    return estadoCivil.ToUpper();
            }
        }

        static string LerDependentes()
        {
            string dependentes;
            while (true)
            {
                Console.WriteLine("Digite quantos dependentes você possui: ");
                dependentes = Console.ReadLine();

                if (ValidaDados.ValidaDependentes(dependentes, out int _))
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("  ERRO - Deve ser entre 0 à 10!");
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine();
                }
            }
            return dependentes;
        }
    }
}