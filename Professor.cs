using System.Linq;

public class Professor : Pessoa
{
    public double SalarioBase {get; set;}
    public List<string> Turmas {get; set;} = new List<string>();
    public double matricula {get; set;}

    public string[] Disciplinas = ["Português", "Matemática", "História", "Física", "Química"];
    private const double ValorBonusPorTurma = 350.00;

    public Professor(string nome, string cpf, DateTime data, double salario, List<string> turma, double matricula, string[] Disciplinas) : base(nome, cpf, data)
    {
        this.SalarioBase = salario;
        this.Turmas = turma;
        this.matricula = matricula;
        this.Disciplinas = Disciplinas;
    }
    public Professor(string nome, string cpf, DateTime data, double salario, double matricula, string[] Disciplinas) 
    : this(nome, cpf, data, salario, new List<string>(), matricula, new string[] {"Português", "Matemática", "História", "Física", "Química"}) 
    {
    
    }
    private double CalcularBonusTurmas()
    {
        return Turmas.Count * ValorBonusPorTurma;
    }

    
    public double CalcularSalarioTotal()
    {
        return SalarioBase + CalcularBonusTurmas();
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine("=== INFORMAÇÕES DO PROFESSOR ===");
        base.ExibirInformacoes(); // Imprime Nome, CPF e Data de Nascimento
        Console.WriteLine($"Salário Bruto: R$ {SalarioBase:F2}");
        Console.WriteLine($"Matrícula: {matricula}"); 
    }

    
    public void ExibirContracheque()
    {
        double bonusTotal = CalcularBonusTurmas();
        double salarioTotal = CalcularSalarioTotal();

        Console.WriteLine($"==========================================");
        Console.WriteLine($"         DEMONSTRATIVO DE PAGAMENTO        ");
        Console.WriteLine($"==========================================");
        Console.WriteLine($"Professor(a): {nome}");
        Console.WriteLine($"Quantidade de Turmas: {Turmas.Count} ({string.Join(", ", Turmas)})");
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"Salário Base:         {SalarioBase:C2}");
        Console.WriteLine($"Bônus por Turmas:    +{bonusTotal:C2} ({Turmas.Count} x {ValorBonusPorTurma:C2})");
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"SALÁRIO LIQUIDO/TOTAL: {salarioTotal:C2}");
        Console.WriteLine($"==========================================");
    }

    
    public void GerarTurmasAleatorias()
    {
        Random random = new Random();
        char[] letras = { 'A', 'B', 'C', 'D', 'E' };
        
        int qtdTurmas = random.Next(1, 6); 

        for (int i = 0; i < qtdTurmas; i++)
        {
            int numero = random.Next(1, 6);
            char letra = letras[random.Next(letras.Length)];
            string turma = $"{numero}{letra}";

            if (!Turmas.Contains(turma))
            {
                Turmas.Add(turma);
            }
        }
        Console.WriteLine("Turmas geradas/atribuídas:");
        foreach (var turma in Turmas)
        {
            Console.WriteLine($"- Turma: {turma}");
        }
    }

    public void SortearDisciplinas(string[] DisciplinasLec, int quantidade)
    {
        if (this.Disciplinas != null && this.Disciplinas.Length > 0)
            return;

        if (DisciplinasLec == null || DisciplinasLec.Length == 0)
        {
            this.Disciplinas = new string[0];
            return;
        }
        Random random = new Random();
        this.Disciplinas = DisciplinasLec
            .OrderBy(d => random.Next())
            .Take(quantidade)
            .ToArray();
        Console.WriteLine("Disciplinas atribuídas:");
        foreach (var d in this.Disciplinas)
        {
            Console.WriteLine($"- {d}");
        }
    }

    public void ExibirDisciplinas()
    {
        Console.WriteLine("Disciplinas atribuídas:");
        if (this.Disciplinas != null && this.Disciplinas.Length > 0)
        {
            foreach (var d in this.Disciplinas)
            {
                Console.WriteLine($"- {d}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma disciplina atribuída.");
        }
    }
}