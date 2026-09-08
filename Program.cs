using System;


class GestaoAcad
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nomePessoa = Console.ReadLine()!;
        Console.Write("Digite seu CPF:");
        double cpfPessoa = double.Parse(Console.ReadLine()!);
        Console.Write("Digite sua data de nascimento: ");
        int dataNascimentoP = int.Parse(Console.ReadLine()!);
        double salarioProfessor = 3500.00;

        Console.WriteLine(@"
        ██████╗░███████╗███╗░░░███╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░░██╗░█████╗░██╗░░
        ██╔══██╗██╔════╝████╗░████║  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗░██╔╝██╔══██╗╚██╗░
        ██████╦╝█████╗░░██╔████╔██║  ╚██╗░██╔╝██║██╔██╗██║██║░░██║██║░░██║██╔╝░███████║░╚██╗
        ██╔══██╗██╔══╝░░██║╚██╔╝██║  ░╚████╔╝░██║██║╚████║██║░░██║██║░░██║╚██╗░██╔══██║░██╔╝
        ██████╦╝███████╗██║░╚═╝░██║  ░░╚██╔╝░░██║██║░╚███║██████╔╝╚█████╔╝░╚██╗██║░░██║██╔╝░
        ╚═════╝░╚══════╝╚═╝░░░░░╚═╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░░░╚═╝╚═╝░░╚═╝╚═╝░░");

        try
        {
            Console.Write("Bem vindo {0}! Informe seu vinculo com a instituição: ", nomePessoa );
            string vin = Console.ReadLine()?.ToLower() ?? "";
            switch (vin)
            {
                case "aluno":
                    double matriculaAluno;
                    Console.Write("Digite sua Matricula: ");
                    while (!double.TryParse(Console.ReadLine(), out matriculaAluno))
                    {
                        Console.Write("Matrícula inválida. Digite apenas números: ");
                    }
                     Aluno aluno = new Aluno(nomePessoa, cpfPessoa, dataNascimentoP, matriculaAluno);
                    fluxoAluno(aluno);
                    break;
                case "professor":
                    Professor professor = new Professor(nomePessoa, cpfPessoa, dataNascimentoP, salarioProfessor);
                    fluxoProfessor(aluno);
                    break;
                default:
                    Console.WriteLine("Vínculo inválido! Escolha 'aluno' ou 'professor'.");
                    break;
            }
        } catch (FormatException)
            {
                    
                Console.WriteLine("Erro de formato: Certifique-se de digitar apenas números válidos.");
            }
            catch (OverflowException)
            {
                  
                Console.WriteLine("Erro de limite: O valor digitado é grande ou pequeno demais.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Dados inválidos: {ex.Message}");
            }
            catch (Exception ex)
            {
                    
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        static void fluxoAluno(Aluno aluno)
        {
            Console.WriteLine("Escolha: 1- Acessar informações, 2- Acessar boletim, 3- Sair");
            int escolha = int.Parse(Console.ReadLine()!);

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("=== INFORMAÇÕES DO ALUNO ===");
                    Console.WriteLine($"Nome: {aluno.getNome(nomePessoa)}");
                    Console.WriteLine($"CPF: {cpfPessoa}");
                    Console.WriteLine($"Data de Nascimento: {dataNascimentoP}");
                    Console.WriteLine($"Matrícula: {matriculaAluno}");
                    break;
                case 2:
                    aluno.boletimFinal();
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
            }
            
        } 
        static void fluxoProfessor(Professor professor)
        {
            Console.WriteLine("Bem-vindo {0}! Por favor, digite as informações abaixo para acessar as opções.", professor.getNome(nomePessoa));
            Console.WriteLine("Digite seu CPF: {0}", cpfPessoa);
            Console.WriteLine("Digite sua data de nascimento:{0}", dataNascimentoP);
            Console.WriteLine("Escolha: 1- Acessar informações, 2- Acessar contracheque, 3- Ver turmas, 4-Sair");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("=== INFORMAÇÕES DO PROFESSOR ===");
                    Console.WriteLine($"Nome: {professor.getNome(nomePessoa)}");
                    Console.WriteLine($"CPF: {cpfPessoa}");
                    Console.WriteLine($"Data de Nascimento: {dataNascimentoP}");
                    Console.WriteLine($"Salario Bruto: {salarioProfessor}");
                    break;
                case 2:
                    professor.ExibirContracheque();
                    break;
                case 3:
                    professor.GerarTurmasAleatorias();
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    break;

            }
        }
    }
}



