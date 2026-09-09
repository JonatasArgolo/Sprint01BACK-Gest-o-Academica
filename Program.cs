using System;
namespace GestaoAcad
{
        class GestaoAcade
    {
        static void Main()
        {
            string nomePessoa = Validador.LerTextoSemNumeros("Digite seu nome: ");
            string cpfPessoa = Validador.LerApenasNumeros("Digite seu CPF: ", tamanhoEsperado: 11);
            DateTime dataNascimentoP = Validador.LerData("Digite sua Data de Nascimento (dd/mm/aaaa): ");
            double salarioProfessor = 3500.00;

            Console.Clear();

            Console.WriteLine(@"
            ██████╗░███████╗███╗░░░███╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░░██╗░█████╗░██╗░░
            ██╔══██╗██╔════╝████╗░████║  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗░██╔╝██╔══██╗╚██╗░
            ██████╦╝█████╗░░██╔████╔██║  ╚██╗░██╔╝██║██╔██╗██║██║░░██║██║░░██║██╔╝░███████║░╚██╗
            ██╔══██╗██╔══╝░░██║╚██╔╝██║  ░╚████╔╝░██║██║╚████║██║░░██║██║░░██║╚██╗░██╔══██║░██╔╝
            ██████╦╝███████╗██║░╚═╝░██║  ░░╚██╔╝░░██║██║░╚███║██████╔╝╚█████╔╝░╚██╗██║░░██║██╔╝░
            ╚═════╝░╚══════╝╚═╝░░░░░╚═╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░░░╚═╝╚═╝░░╚═╝╚═╝░░");

            try
            {
                    string vin = "";
                do
                {
                    while (vin != "aluno" && vin != "professor")
                    {
                        Console.Write("Bem vindo {0}! Informe seu vinculo com a instituição: (aluno/professor)", nomePessoa );
                        vin = Console.ReadLine()?.ToLower().Trim() ?? "";

                        if (vin != "aluno" && vin != "professor")
                        {
                        Console.WriteLine("Opção inválida! Por favor, informe 'aluno' ou 'professor'.\n");
                        }
                    }   
                } while(vin != "aluno" && vin != "professor");
                Console.Clear();
                switch (vin)
                {
                    case "aluno":
                        double matriculaAluno;
                        Console.Write("Digite sua Matricula: ");
                        while (!double.TryParse(Console.ReadLine(), out matriculaAluno))
                        {
                            Console.Write("Matrícula inválida. Digite apenas números: ");
                        }
                        Console.Clear();
                        Aluno aluno = new Aluno(nomePessoa, cpfPessoa, dataNascimentoP, matriculaAluno);
                        fluxoAluno(aluno);
                        break;
                    case "professor":
                        Professor professor = new Professor(nomePessoa, cpfPessoa, dataNascimentoP, salarioProfessor);
                        fluxoProfessor(professor);
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
            void fluxoAluno(Aluno aluno)
            {
                bool executando = true;

                while (executando)
                {
                    Console.WriteLine("Escolha: 1- Acessar informações, 2- Acessar boletim, 3- Sair");
                    int escolha = int.Parse(Console.ReadLine()!);

                    switch(escolha)
                    {
                        case 1:
                            Console.WriteLine("=== INFORMAÇÕES DO ALUNO ===");
                            Console.WriteLine($"Nome: {aluno.getNome()}");
                            Console.WriteLine($"CPF: {cpfPessoa}");
                            Console.WriteLine($"Data de Nascimento: {dataNascimentoP}");
                            Console.WriteLine($"Matrícula: {aluno.matricula}");
                            break;
                        case 2:
                            aluno.boletimFinal();
                            break;
                        case 3:
                        executando = false;
                            Console.WriteLine("Saindo...");
                            break;
                    }
                    Console.WriteLine("\n" + new string('-', 30));
                }
            } 
            void fluxoProfessor(Professor professor)
            {
                bool executando = true;

                while (executando)
                {
                    
                    Console.WriteLine("Escolha: 1- Acessar informações, 2- Acessar contracheque, 3- Ver turmas, 4-Sair");
                    int escolha = int.Parse(Console.ReadLine()!);
                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine("=== INFORMAÇÕES DO PROFESSOR ===");
                            Console.WriteLine($"Nome: {professor.getNome()}");
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
                        executando = false;
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            break;

                    }
                    Console.WriteLine("\n" + new string('-', 30));
                }
            }
        }
    }
}