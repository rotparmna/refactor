namespace Masiv.Printer.Refactor
{
    public class GeneratePrimeNumber
    {
        public int QuantityToGenerate { get; set; }

        public int[] NumbersGenerated { get; set; }

        public GeneratePrimeNumber(int quantityToGenerate)
        {
            this.QuantityToGenerate = quantityToGenerate;
        }

        public void Generate()
        {
            int K = 1;
            int M = this.QuantityToGenerate;
            int SQUARE = 9;
            int J = 1;
            int ORD = 2;
            int ORDMAX = 30;
            int[] MULT = new int[ORDMAX + 1];
            int[] P = new int[M + 1];
            int N = 0;
            P[1] = 2;
            bool JPRIME;
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
            this.NumbersGenerated = P;
        }
    }
}
