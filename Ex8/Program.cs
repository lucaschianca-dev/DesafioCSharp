using Ex8;

class Program
{
    static void Main(string[] args)
    {
        string nome = LerNome();
        Pessoa pessoa = new Pessoa(nome);

        static string LerNome()
        {
            string nome;
            while (true)
            {
                Console.Write("Digite o nome (pelo menos 5 caracteres): ");
                nome = Console.ReadLine();
                if (ValidaDados.ValidaNome(nome))
                    break;
                Console.WriteLine("ERRO");
            }
            Console.WriteLine($"Nome digitado: {nome}");
            return nome;
        }
    }
}