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
            int n = int.Parse(Console.ReadLine);
            AluguelQuarto[] aluguelQuarto = new AluguelQuarto[10];

        }
    }
}
