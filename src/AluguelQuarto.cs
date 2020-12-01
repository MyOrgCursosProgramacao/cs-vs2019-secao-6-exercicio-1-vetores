using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    class AluguelQuarto
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public AluguelQuarto()
        {
        }

        public AluguelQuarto(string nome, string email)
        {
            SetNome(nome);
            SetEmail(email);
        }

        public void SetNome(string nome)
        {
            bool loop = true;
            do
            {
                if (nome.Equals(null) || nome.Length < 5 || nome.StartsWith(' '))
                {
                    Console.WriteLine(Environment.NewLine
                        + "O nome do estudante deve ter um formato válido e mais de 5 letras. "
                        + Environment.NewLine
                        + "Digite o nome do estudante: ");
                    nome = Console.ReadLine();
                }
                else
                {
                    Nome = nome;
                    loop = false;
                }
            } while (loop);
        }

        public void SetEmail(string email)
        {
            bool loop = true;
            do
            {
                if (email.Equals(null) || email.StartsWith(' ') || !email.Contains('@') || !email.Contains('.'))
                {
                    Console.WriteLine(Environment.NewLine
                        + "O E-mail do estudante deve ter um formato válido (nome@servidor.com). "
                        + Environment.NewLine
                        + "Digite o E-mail do estudante: ");
                    email = Console.ReadLine();
                }
                else
                {
                    Email = email;
                    loop = false;
                }
            } while (loop);
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Email;
        }
    }
}
