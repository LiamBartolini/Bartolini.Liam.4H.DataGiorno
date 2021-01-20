using System;
using Bartolini.Liam._4H.DataGiorno.Models;

namespace Bartolini.Liam._4H.DataGiorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data("22, 08, 01");
            Console.WriteLine("Data originale: ");
            Console.WriteLine(data.Out());

            try
            {
                data.Mod(31, 2, -3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nData Modificata");
                Console.WriteLine(data.Out());
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();
            }
        }
    }
}