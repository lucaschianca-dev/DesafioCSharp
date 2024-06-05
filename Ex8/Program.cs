using Ex8;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string nome = LerNome();
        String cpf = LerCpf();
        //data
        String rendaMensal = LerRendaMensal(out float rendaMensalFloat);
        String estadoCivil = LerEstadoCivil();
        String dependentes = LerDependentes();

        Pessoa pessoa = new Pessoa(nome, cpf,/*dataDeNascimento,*/ rendaMensal, estadoCivil, dependentes);

        Console.WriteLine(":---------DADOS---------:");
        Console.WriteLine($"  Nome: {pessoa.Nome}");
        Console.WriteLine($"  CPF: {pessoa.Cpf}");
        // Console.WriteLine($"Data de Nascimento: {dataDeNascimento:dd/MM/yyyy}");
        Console.WriteLine($"  Renda Mensal: {pessoa.RendaMensal}");
        Console.WriteLine($"  Estado Civil: {pessoa.EstadoCivil}");
        Console.WriteLine($"  Dependentes: {pessoa.Dependentes}");

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
                Console.WriteLine("ERRO - O campo deve conter mais de 5 caracteres!");
            }
            Console.WriteLine($"Nome digitado: {nome}");
            Console.WriteLine();
            return nome;
        }

        static string LerCpf()
        {
            string cpf;
            while (true)
            {
                Console.WriteLine("Digite o CPF: ");
                cpf = Console.ReadLine();

                if (ValidaDados.ValidaCpf(cpf))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERRO - CPF inválido!");
                }                                       
            }
            Console.WriteLine($"CPF digitado: {cpf}");
            Console.WriteLine();
            return cpf;
        }

        static string LerRendaMensal(out float rendaMensalFloat)
        {
            string rendaMensalStr;
            int beneficio = 550; //<- Usei este atributo para testar se o valor da renda é validado,
                                 //convertido para float corretamente,
                                 //feito os cálculos e retornado como String para ser armazenado na entidade Pessoa.
            while (true)
            {
                Console.Write("Digite a sua renda mensal: ");
                rendaMensalStr = Console.ReadLine();

                if (ValidaDados.ValidaRendaMensal(rendaMensalStr, out rendaMensalFloat))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERRO - Sua renda deve ser maior que 0!");
                }
            }
            Console.WriteLine($"Valor digitado: {rendaMensalStr}");
            Console.WriteLine($"Calculando Benefícios: {rendaMensalFloat += beneficio}");
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
                    Console.WriteLine("ERRO");
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
                    Console.WriteLine("ERRO");
                }
            }
            return dependentes;
        }
    }
}