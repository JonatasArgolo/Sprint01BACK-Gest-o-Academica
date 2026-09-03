public class Professor : Pessoa
{
    public double salario {get; set;}
    public List<int> Turma {get; set;} = new List<int>();

    public Professor(string nome, double cpf, int data, double salario, List<int> turma) : base(nome, (int)cpf, (int)data)
    {
        this.salario = salario;
        this.Turma = turma;
    }
    public Professor(string nome, double cpf, int data, double salario) 
    : this(nome, cpf, data, salario, new List<int>()) 
    {
    
    }
}