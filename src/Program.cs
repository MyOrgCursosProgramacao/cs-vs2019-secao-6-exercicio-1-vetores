using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do Exercício proposto 1 da Seção 6" + Environment.NewLine);
            Console.WriteLine("Entre com os dados dos alugueis dos quartos.");

            Console.Write(Environment.NewLine + "Quantos alugueis serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            AluguelQuarto[] aluguelQuarto = new AluguelQuarto[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Environment.NewLine + $"Dados do {i} aluguel:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                aluguelQuarto[quarto] = new AluguelQuarto(nome, email);
            }

            Console.WriteLine(Environment.NewLine, "Quartos ocupados:");
            for (int i = 1; i <= 10; i++)
            {
                if (aluguelQuarto[i] != null)
                {
                    Console.WriteLine("Quarto {i}: " + aluguelQuarto[i]);               
                }
            }

            Console.WriteLine();
        }
    }
}
