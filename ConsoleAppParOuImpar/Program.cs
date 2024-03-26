using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escolha Pares ou impares[0-par, 1- impar]");
            int escol = int.Parse(Console.ReadLine());
            int cont = escol;
            Console.Clear();
            while (cont <= 20) {
                
                Console.WriteLine(cont);
                cont += 2;
            }
            Console.ReadKey();
        }
    }
}
