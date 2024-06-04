namespace Ex8;

public class ValidaDados
{
    public static bool ValidaNome(string nome)
    {
        return nome.Length >= 5;
    }

    public static bool ValidaCpf(string cpf)
    {
        return cpf.Length >= 5;
    }
}
