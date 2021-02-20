using System;

namespace Masiv.Printer.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int RR = 50;
            int CC = 4;
            int PAGENUMBER;
            int PAGEOFFSET;
            int ROWOFFSET;
            int C;
            GeneratePrimeNumber generatePrimeNumber = new GeneratePrimeNumber(1000);
            generatePrimeNumber.Generate();
            int[] P = generatePrimeNumber.NumbersGenerated;
            PAGENUMBER = 1;
            PAGEOFFSET = 1;
            while (PAGEOFFSET <= generatePrimeNumber.QuantityToGenerate)
            {
                Console.Write("The First ");
                Console.Write(generatePrimeNumber.QuantityToGenerate.ToString());
                Console.Write(" Prime Numbers === Page ");
                Console.Write(PAGENUMBER.ToString());
                Console.WriteLine("\n");
                for (ROWOFFSET = PAGEOFFSET; ROWOFFSET <= PAGEOFFSET + RR - 1; ROWOFFSET++)
                {
                    for (C = 0; C <= CC - 1; C++)
                        if (ROWOFFSET + C * RR <= generatePrimeNumber.QuantityToGenerate)
                            Console.Write(P[ROWOFFSET + C * RR].ToString().PadLeft(10));
                    Console.WriteLine();
                }
                Console.WriteLine("\f");
                PAGENUMBER++;
                PAGEOFFSET += RR * CC;
            }
        }
    }
}
