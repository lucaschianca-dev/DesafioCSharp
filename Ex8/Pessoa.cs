﻿namespace Ex8;

public class Pessoa
{
    private string _nome { get; set; }
    private long _cpf { get; set; }
    private DateTime _dataDeNascimento { get; set; }
    private string _rendaMensal { get; set; }
    private char _estadoCivil { get; set; }
    private int _dependentes { get; set; }

    public Pessoa(string nome, long cpf, DateTime dataDeNascimento, string rendaMensal, char estadoCivil, int dependentes)
    {
        _nome = nome;
        _cpf = cpf;
        _dataDeNascimento = dataDeNascimento;
        _rendaMensal = rendaMensal;
        _estadoCivil = estadoCivil;
        _dependentes = dependentes;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public long Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public DateTime DataDeNascimento
    {
        get { return _dataDeNascimento; }
        set { _dataDeNascimento = value; }
    }

    public string RendaMensal
    {
        get { return _rendaMensal; }
        set { _rendaMensal = value; }
    }

    public char EstadoCivil
    {
        get { return _estadoCivil; }
        set { _estadoCivil = value; }
    }

    public int Dependentes
    {
        get { return _dependentes; }
        set { _dependentes = value; }
    }
}
