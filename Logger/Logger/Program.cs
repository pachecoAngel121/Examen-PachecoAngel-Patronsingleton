using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Divide(5, 0);

            Console.ReadKey();
        }
    }
}
