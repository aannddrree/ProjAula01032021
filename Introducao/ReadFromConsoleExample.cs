using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class ReadFromConsoleExample
    {
        static void Main (string[] args)
        {

            string nome;
            int idade;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("O seu nome é: " + nome + " e você tem " + idade + "");

            Console.ReadKey();
        }        
    }
}
