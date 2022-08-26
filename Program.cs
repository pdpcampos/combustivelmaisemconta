using System;
using Combustivel;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Programa para calcular o combustivel mais em conta");
            Calclular c = new Calclular();
            Console.WriteLine("informe o valor do alcool");
            c.combustivel1 = float.Parse (Console.ReadLine());
           
            Console.WriteLine("Informe o valor da Gasolina");
            c.combustivel2 = float.Parse(Console.ReadLine());
            
            c.ExibirDados();
            Console.ReadKey();
        }
    }
}
