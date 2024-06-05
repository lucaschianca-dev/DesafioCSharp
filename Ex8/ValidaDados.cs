using System.Globalization;

namespace Ex8;

public class ValidaDados
{
    public static bool ValidaNome(string nome)
    {
        return nome.Length >= 5;
    }

    public static bool ValidaCpf(string cpf)
    {
        return cpf.Length == 11;
    }

    //public static bool ValidaDataNascimento(string dataNascimento, out DateTime _dataDeNascimento)
    //{

    //}

    public static bool ValidaRendaMensal(string rendaMensalStr, out float rendaMensalFloat)
    {
        return float.TryParse
            (
            rendaMensalStr,
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out rendaMensalFloat
            )
            && rendaMensalFloat >= 0;
    }

    public static bool ValidaEstadoCivil(string estadoCivil)
    {
        estadoCivil = estadoCivil.ToUpper();
        return estadoCivil.Length == 1 && "CSVD".Contains(estadoCivil);
    }

    public static bool ValidaDependentes(string dependentesStr, out int dependentes)
    {
        return int.TryParse
            (
            dependentesStr, 
            NumberStyles.Integer, 
            CultureInfo.InvariantCulture, 
            out dependentes
            ) && dependentes >= 0 && dependentes <= 10;
    }
}
