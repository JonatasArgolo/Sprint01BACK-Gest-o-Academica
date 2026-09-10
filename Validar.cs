using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GestaoAcad
{
    public static class Validador
    {
        
        public static string LerTextoSemNumeros(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entradaBruta = Console.ReadLine() ?? " ";
                string entrada = entradaBruta.Trim();
                bool temLetrasRepetidas = Regex.IsMatch(entrada, @"(.)\1{2,}");
                bool formatoValido = Regex.IsMatch(entrada, @"^[a-zA-ZÀ-ÿ]{2,30}( [a-zA-ZÀ-ÿ]{2,30})*$");

                if (!string.IsNullOrWhiteSpace(entrada) && formatoValido && !temLetrasRepetidas)
                {
                    return Regex.Replace(entrada, @"\s+", " ");
        }

                Console.WriteLine("Erro: Entrada inválida. Digite apenas letras!\n");
            }
        }

        
        public static string LerApenasNumeros(string mensagem, int? tamanhoEsperado = null)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine()!;

                bool apenasNumeros = !string.IsNullOrWhiteSpace(entrada) && entrada.All(char.IsDigit);
                bool tamanhoValido = tamanhoEsperado == null || entrada.Length == tamanhoEsperado;

                if (apenasNumeros && tamanhoValido)
                    return entrada;

                string msgTamanho = tamanhoEsperado.HasValue ? $" com exatamente {tamanhoEsperado} dígitos" : "";
                Console.WriteLine($"Erro: Digite apenas números{msgTamanho}!\n");
            }
        }

        
        public static int LerInteiro(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out int valor))
                    return valor;

                Console.WriteLine("Erro: Digite um número inteiro válido!\n");
            }
        }
        public static DateTime LerData(string mensagem)
        {
        while (true)
        {
            Console.Write(mensagem);
        
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dataValida))
            return dataValida;

            Console.WriteLine("Erro: Digite uma data válida (ex: 20/05/2000)!\n");
            }
        }
    }
}