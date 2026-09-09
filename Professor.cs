public class Professor : Pessoa
{
    public double SalarioBase {get; set;}
    public List<string> Turmas {get; set;} = new List<string>();
    private const double ValorBonusPorTurma = 350.00;

    public Professor(string nome, string cpf, DateTime data, double salario, List<string> turma) : base(nome, cpf, data)
    {
        this.SalarioBase = salario;
        this.Turmas = turma;
    }
    public Professor(string nome, string cpf, DateTime data, double salario) 
    : this(nome, cpf, data, salario, new List<string>()) 
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
}