using System;

namespace velocidade
{
    class Program
    {
        static void Main(string[] args)
        {
          
          Console.ForegroundColor = ConsoleColor.DarkMagenta;
          Console.WriteLine("Velocidade");
          Console.ResetColor();
          Console.WriteLine();
          Console.WriteLine("Distância percorrida(m):");
          double d = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Tempo gasto (s):");
          double t = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine();
          double v = d / t;
          Console.WriteLine($"Velocidade média :{v} m/s");




          

          
        
        

        }
    }
}
