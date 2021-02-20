using System;

namespace Masiv.Printer.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 1000;
            int RR = 50;
            int CC = 4;
            int ORDMAX = 30;
            int[] P = new int[M + 1];
            int PAGENUMBER;
            int PAGEOFFSET;
            int ROWOFFSET;
            int C;
            int J;
            int K;
            bool JPRIME;
            int ORD;
            int SQUARE;
            int N = 0;
            int[] MULT = new int[ORDMAX + 1];
            J = 1;
            K = 1;
            P[1] = 2;
            ORD = 2;
            SQUARE = 9;
            while (K < M)
            {
                do
                {
                    J += 2;
                    if (J == SQUARE)
                    {
                        ORD++;
                        SQUARE = P[ORD] * P[ORD];
                        MULT[ORD - 1] = J;
                    }
                    N = 2;
                    JPRIME = true;
                    while (N < ORD && JPRIME)
                    {
                        while (MULT[N] < J)
                            MULT[N] += P[N] + P[N];
                        if (MULT[N] == J)
                            JPRIME = false;
                        N++;
                    }
                } while (!JPRIME);
                K++;
                P[K] = J;
            }
            PAGENUMBER = 1;
            PAGEOFFSET = 1;
            while (PAGEOFFSET <= M)
            {
                Console.Write("The First ");
                Console.Write(M.ToString());
                Console.Write(" Prime Numbers === Page ");
                Console.Write(PAGENUMBER.ToString());
                Console.WriteLine("\n");
                for (ROWOFFSET = PAGEOFFSET; ROWOFFSET <= PAGEOFFSET + RR - 1; ROWOFFSET++)
                {
                    for (C = 0; C <= CC - 1; C++)
                        if (ROWOFFSET + C * RR <= M)
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
