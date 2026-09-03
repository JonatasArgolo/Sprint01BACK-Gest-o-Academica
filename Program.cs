using System;

namespace GestaoAcad
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Jonatas", 97585847436, 06102007, 026067792 );
            Professor professor = new Professor("Caua", 87629473821, 04062003, 034078621);


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

                if(vin == "aluno")
                {
                    Console.WriteLine("Bem-vindo {0}! Por favor, digite as informações abaixo para acessar as opções.", aluno.getNome(aluno));
                    Console.WriteLine("Digite sua matricula:");
                    
                    Console.WriteLine("Digite seu CPF:");
                    Console.WriteLine("Digite sua data de nascimento:");

                }

            }
            catch (Exception err)
            {
                
            }

            aluno.boletimFinal();
        }
    }
}