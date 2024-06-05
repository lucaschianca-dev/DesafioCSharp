using Ex8;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string nome = LerNome();
        long cpf = LerCpf(out long cpfLong);
        DateTime dataDeNascimento = LerDataNascimento();
        String rendaMensal = LerRendaMensal(out float rendaMensalFloat);
        char estadoCivil = LerEstadoCivil();
        int dependentes = LerDependentes(out int dependentesInt);

        Pessoa pessoa = new Pessoa(nome, cpf, dataDeNascimento, rendaMensal, estadoCivil, dependentes);

        int comprimentoMaximo = 18;

        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("|               DADOS               |");
        Console.WriteLine("=====================================");
        Console.WriteLine($"| Nome:           {pessoa.Nome.PadRight(comprimentoMaximo)}|");
        Console.WriteLine($"| CPF:            {pessoa.Cpf:D11}       |");
        Console.WriteLine($"| Nascimento:     {dataDeNascimento:dd/MM/yyyy}".PadRight(comprimentoMaximo) + "|");
        Console.WriteLine($"| Renda Mensal:   R$ {pessoa.RendaMensal}".PadRight(comprimentoMaximo + 7) + "|");
        Console.WriteLine($"| Estado Civil:   {pessoa.EstadoCivil}                 |");
        Console.WriteLine($"| Dependentes:    {pessoa.Dependentes}                 |");
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

        static char LerEstadoCivil()
        {
            string estadoCivilStr;
            while (true)
            {
                Console.WriteLine("Digite seu estado civil [C - Casado(a) / S - Solteiro(a) / V - Viúvo(a) / D - Divorciado(a)]: ");
                estadoCivilStr = Console.ReadLine();

                if (!string.IsNullOrEmpty(estadoCivilStr) && ValidaDados.ValidaEstadoCivil(estadoCivilStr[0]))
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

            char estadoCivilChar = char.ToUpper(estadoCivilStr[0]);
            switch (estadoCivilChar)
            {
                case 'C':
                    Console.WriteLine("Regime selecionado: Casado(a)");
                    break;
                case 'S':
                    Console.WriteLine("Regime selecionado: Solteiro(a)");
                    break;
                case 'V':
                    Console.WriteLine("Regime selecionado: Viúvo(a)");
                    break;
                case 'D':
                    Console.WriteLine("Regime selecionado: Divorciado(a)");
                    break;
            }
            Console.WriteLine();
            return estadoCivilChar;
        }

        static int LerDependentes(out int dependentesInt)
        {
            string dependentesStr;
            while (true)
            {
                Console.WriteLine("Digite quantos dependentes você possui: ");
                dependentesStr = Console.ReadLine();

                if (ValidaDados.ValidaDependentes(dependentesStr, out dependentesInt))
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
            return dependentesInt;
        }

        static DateTime LerDataNascimento()
        {
            DateTime dataNascimento;

            while (true)
            {
                Console.Write("Digite sua data de nascimento (DD/MM/AAAA): ");
                String dataNascimentoStr = Console.ReadLine();

                if (ValidaDados.ValidaDataNascimento(dataNascimentoStr, out dataNascimento))
                {
                    int idade = ValidaDados.CalculaIdade(dataNascimento);

                    Console.WriteLine($"Data de nascimento digitada: {dataNascimento}");
                    Console.WriteLine($"Idade selecionada: {idade}");
                    Console.WriteLine("");
                    break ;
                }
                Console.WriteLine();
                Console.WriteLine("+-------------------------------------------------------------------------------+");
                Console.WriteLine("  ERRO - Data de nascimento inválida ou o cliente deve ter pelo menos 18 anos.");
                Console.WriteLine("+-------------------------------------------------------------------------------+");
                Console.WriteLine();
            }
            return dataNascimento;
        }
    }
}