namespace Ex7.Extensoes;

public static class ExtensaoArmstrong
{
    public static bool IsArmstrong(this int numero)
    {
        string numeroStr = numero.ToString();
        int numeroDigitos = numeroStr.Length;

        int soma = numeroStr.Sum(digto => (int)Math.Pow(char.GetNumericValue(digto), numeroDigitos));

        return soma == numero;
    }
}
