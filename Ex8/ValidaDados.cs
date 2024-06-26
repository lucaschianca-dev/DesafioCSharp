﻿using System.Globalization;

namespace Ex8;

public class ValidaDados
{
    public static bool ValidaNome(string nome)
    {
        return nome.Length >= 5;
    }

    public static bool ValidaCpf(string cpf, out long cpfLong)
    {
        if (cpf.Length == 11 && long.TryParse(cpf, out cpfLong))
        {
            return true;
        }
        else
        {
            cpfLong = 0;
            return false;
        }
    }

    public static bool ValidaDataNascimento(string dataNascimentoStr, out DateTime dataNascimento)
    {
        bool formatoValido = DateTime.
            TryParseExact
            (dataNascimentoStr,
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out dataNascimento);

        if (formatoValido)
        {
            int idade = CalculaIdade(dataNascimento);
            return idade > 18;
        }
        return false;
    }

    public static int CalculaIdade(DateTime dataNascimento)
    {
        int idade = DateTime.Now.Year - dataNascimento.Year;
        return idade;
    }

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

    public static bool ValidaEstadoCivil(char estadoCivil)
    {
        return "CSVDcsdv".Contains(estadoCivil);
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
