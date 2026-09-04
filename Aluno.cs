using System;

public class Aluno : Pessoa
{

    public double matricula {get; set;}
    public List<double> notas {get; set;} = new List<double>();

    public Dictionary<string, double> Boletim {get; set;} = new Dictionary<string,double>();
    public string[] materia;
    
    public Aluno(string nome, double cpf, int data, double matricula, List<double> notas, Dictionary<string, double> boletim, string[] materia) : base (nome, (int)cpf, (int)data)
    {
        this.matricula = matricula;
        this.notas = notas;
        this.Boletim = boletim;
        this.materia = materia;
    }

    public Aluno(string nome, double cpf, int data, double matricula) 
    : this(nome, cpf, data, matricula, new List<double>(), new Dictionary<string, double>(), new string[5]) 
    {
    
    }

    public void GerarBoletim()
    {
        materia = ["Matemática", "Português", "História", "Física", "Química"];
        Random rand = new Random();

        foreach(var mat in materia)
        {
            Boletim[mat] = Math.Round(rand.NextDouble() * 10, 1);
        }
    }

    public double MediaGeral
    {
        get
        {
            if(Boletim.Count == 0)
            {
                return 0.0;
            }
            double soma = 0;
            foreach(double nota in Boletim.Values)
            {
                soma += nota;
            }

            double media = soma / Boletim.Count;
            return Math.Round(media, 1);
        }
    }

    public void boletimFinal()
    {
        GerarBoletim();

        Console.WriteLine($"=== BOLETIM DO ALUNO: {nome} ===");
        for(int i=0; i < notas.Count(); i++)
        {
            Console.WriteLine($"{materia[i]}: {notas[i]}");
        }
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Média Geral : {MediaGeral}");
    }

    internal object? getNome(object nome)
    {
        throw new NotImplementedException();
    }
}