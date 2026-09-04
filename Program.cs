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
                    Console.WriteLine("Bem-vindo {0}! Por favor, digite as informações abaixo para acessar as opções.", aluno.getNome(nomePessoa));
                    Console.Write("Digite sua matricula: {0}", matriculaAluno);
                    Console.WriteLine("Digite seu CPF: {0}", cpfPessoa);
                    Console.WriteLine("Digite sua data de nascimento:{0}", dataNascimentoP);
                    Console.Clear();

                    switch (matriculaAluno)
                    {
                        
                    
                        Console.WriteLine("Bem-vindo {0}! Por favor, escolha uma das opções abaixo.", aluno.getNome(nomePessoa));
                        Console.WriteLine("1- ");
                    }
                case "professor":
            }
        }
        static void fluxoAluno()
        {
            Console.WriteLine("Bem-vindo {0}! Por favor, digite as informações abaixo para acessar as opções.", aluno.getNome(nomePessoa));
        }   
    }
}



