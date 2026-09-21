using System;
using GestaoAcad;

public abstract class Pessoa : IImprimivel
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

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento:dd/MM/yyyy}");
    }
}