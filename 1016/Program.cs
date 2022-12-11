using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ConsumoAutomovel = 12, TempoGasto, VelocidadeMedia;
            double ConsumoFinal;

            TempoGasto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VelocidadeMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            ConsumoFinal = TempoGasto * VelocidadeMedia;
            ConsumoFinal = ConsumoFinal / ConsumoAutomovel;

            Console.WriteLine(ConsumoFinal.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}