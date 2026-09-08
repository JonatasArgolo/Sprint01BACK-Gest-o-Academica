using System;


class GestaoAcad
{
    static void Main()
    {
        string nomePessoa = Console.ReadLine()!;
        double cpfPessoa = double.Parse(Console.ReadLine()!);
        int dataNascimentoP = int.Parse(Console.ReadLine()!);;
        double matriculaAluno = double.Parse(Console.ReadLine()!);;
        double salarioProfessor = 3500.00;

        Aluno aluno = new Aluno(nomePessoa, cpfPessoa, dataNascimentoP, matriculaAluno);
        Professor professor = new Professor(nomePessoa, cpfPessoa, dataNascimentoP, salarioProfessor);


        Console.WriteLine(@"
        ██████╗░███████╗███╗░░░███╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░░██╗░█████╗░██╗░░
        ██╔══██╗██╔════╝████╗░████║  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗░██╔╝██╔══██╗╚██╗░
        ██████╦╝█████╗░░██╔████╔██║  ╚██╗░██╔╝██║██╔██╗██║██║░░██║██║░░██║██╔╝░███████║░╚██╗
        ██╔══██╗██╔══╝░░██║╚██╔╝██║  ░╚████╔╝░██║██║╚████║██║░░██║██║░░██║╚██╗░██╔══██║░██╔╝
        ██████╦╝███████╗██║░╚═╝░██║  ░░╚██╔╝░░██║██║░╚███║██████╔╝╚█████╔╝░╚██╗██║░░██║██╔╝░
        ╚═════╝░╚══════╝╚═╝░░░░░╚═╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░░░╚═╝╚═╝░░╚═╝╚═╝░░");

        try
        {
            Console.Write("Usuário, informe seu vinculo com a instituição:");
            string vin = Console.ReadLine()!;
            switch (vin.ToLower())
            {
                case "aluno":
                    fluxoAluno();
                    break;
                case "professor":
                    fluxoProfessor();
                    break;
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        void fluxoAluno()
        {
            Console.WriteLine("Bem-vindo {0}! Por favor, digite as informações abaixo para acessar as opções.", aluno.getNome(nomePessoa));
            Console.Write("Digite sua matricula: {0}", matriculaAluno);
            Console.WriteLine("Digite seu CPF: {0}", cpfPessoa);
            Console.WriteLine("Digite sua data de nascimento:{0}", dataNascimentoP);
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
        void fluxoProfessor()
        {
            
        }
    }
}



