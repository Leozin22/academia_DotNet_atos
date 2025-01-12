﻿namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Nome, idade, sexo, email, telefone, estado civil, casa propria ou não, valor aluguel
            Gerar um arquivo, utilizando o; como caractere delimitador para cada uma dessas informações.
            Todas as informações, ficam na mesma linha -cada linha é uma pessoa
            apenas nome, idade e casa propria são campos obrigatórios
            EXEMPLO
            Fabrício; 21; ; ; ; ; sim; 0
                */

            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe o email");
            string email = Console.ReadLine();

            Console.WriteLine("Informe o fone");
            string fone = Console.ReadLine();

            Console.WriteLine("Informe o estado civil");
            string estado = Console.ReadLine();

            Console.WriteLine("Tem casa propria? (1 = SIM, 2 = NÃO");
            int casa = int.Parse(Console.ReadLine());

            double aluguel = 0;
            if (casa == 2)
            {
                Console.WriteLine("Informe o aluguel");
                aluguel = double.Parse(Console.ReadLine());
            }

            List<string> linhas = new List<string>();

            if (File.Exists(@"C:\Users\fabri\Desktop\exemplo2.txt"))
            {
                StreamReader reader = new StreamReader(@"C:\Users\fabri\Desktop\exemplo2.txt");


                linhas.Add(reader.ReadLine());

                string linha = "";

                while (linha != null)
                {
                    linha = reader.ReadLine();

                    if (linha != null)
                        linhas.Add(linha);
                }

                reader.Close();

            }

            linhas.Add(nome + ";" + idade + ";" + sexo + ";" + email + ";" + fone + ";" + estado + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel);

            StreamWriter writer = new StreamWriter(@"C:\Users\fabri\Desktop\exemplo2.txt");

            foreach (string item in linhas)
            {
                writer.WriteLine(item);
            }

            writer.Close();


        }
    }
}