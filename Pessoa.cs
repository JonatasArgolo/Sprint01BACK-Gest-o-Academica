using System;

public abstract class Pessoa
{
    protected string nome;
    protected double cpf;
    protected double dataNascimento;

    public Pessoa(string nome, int cpf, double data)
    {
    this.nome = nome;
    this.cpf = cpf;
    this.dataNascimento = data;
    }

    public string getNome (string nome)
    {
        return this.nome;
    }

    public int getCPF(double cpf)
    {
        return (int)this.cpf;
    }

    public int getData(double data)
    {
        return (int)this.dataNascimento;
    }
}