using System;

namespace Entrada_e_Saida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Bruno";
            int idade = 24;
            double saldo = 10.50456;
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine("----------------------------------------");
            
            string produto = "Computador";
            double valor = 2.500;
            int quantidade = 10;
            double total = valor * quantidade;
            Console.WriteLine("Você escolheu " + produto);
            Console.WriteLine("O valor do computador é de: " + valor.ToString("F3"));
            Console.WriteLine("Você comprou " + quantidade + " Computadores");
            Console.WriteLine("O total da compra foi de: " + total.ToString("F3"));
            Console.WriteLine("----------------------------------------");

            string aluno = "Bruno";
            int introducao = 10;
            double proj = 8.6;
            int git = 10;
            double med = introducao + proj + git / 2;
            Console.WriteLine("Aluno: " + aluno);
            Console.WriteLine("Introdução ao C#: " + introducao);
            Console.WriteLine("Criar projeto e Solução: " + proj);
            Console.WriteLine("Enviar ao GTIHUB: " + git);
            Console.WriteLine("A média do aluno é de: " + med);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Concatenação");
            Console.WriteLine(nome + " Tem " + idade + " anos e tem o saldo de: " + saldo.ToString("F2"));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Placeholders");
            Console.WriteLine("{0} tem {1} anos e tem o saldo de: {2}", nome, idade, saldo.ToString("F2"));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Interpolação");
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo de: {saldo}");





        }
    }
}
