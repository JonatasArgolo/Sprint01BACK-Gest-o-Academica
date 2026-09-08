using System;

public abstract class Pessoa
{
    protected string nome;
    protected string cpf;
    protected DateTime dataNascimento;

    public Pessoa(string nome, string cpf, DateTime data)
    {
    this.nome = nome;
    this.cpf = cpf;
    this.dataNascimento = data;
    }

    public string getNome ()
    {
        return this.nome;
    }

    public string getCPF(string cpf)
    {
        return this.cpf;
    }

    public DateTime getData(DateTime data)
    {
        return this.dataNascimento;
    }
}