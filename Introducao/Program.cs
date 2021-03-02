using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "André";
            Console.WriteLine("Ex1 - Nome: " + nome);

            int a = 2;
            int b = 3;
            int c = a + b;

            Console.WriteLine("Ex2 - Soma de A + B: " + c);
            Console.WriteLine("Ex3 - Soma de A + B: " + a + b);
            Console.WriteLine("Ex4 - Soma de A + B: " + (a + b));

            string texto = "Ex5 - O meu nome é " + nome + "\nEu tenho " + c + " livros";
            Console.WriteLine(texto);

            bool isValid = true; 
            bool isNotValid = false;

            Console.WriteLine("Ex6 - isValid: " + isValid + "\nisNotValid:" + isNotValid);

            char letra = nome[3];
            Console.WriteLine("Ex7 - Nome[3]: " + letra);

            //Console.WriteLine("Hello World!");

            // Comentário uma linha

            /*
             * Comentário Bloco
             * 
             */

            Console.ReadKey();
        }
    }
}
