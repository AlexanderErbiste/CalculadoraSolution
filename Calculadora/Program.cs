using System;
using Etec.FP.Negocios;

class Program
{
    static void Main(string[] args)
    {
        Calculadora Calc1 = new Calculadora();

        Console.Write("10 + 10 = ");
        Console.Write(Calc1.Somar(10, 10));

        Console.WriteLine();
        Console.Write("10 - 10 = ");
        Console.Write(Calc1.Subtrair(10, 10));

        Console.WriteLine();
        Console.Write("10 * 10 = ");
        Console.Write(Calc1.Multiplicar(10, 10));

        Console.WriteLine();
        Console.Write("10 / 10 =");
        Console.Write(Calc1.Dividir(10, 10));
    
    }
}
