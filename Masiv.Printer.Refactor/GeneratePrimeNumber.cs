namespace Masiv.Printer.Refactor
{
    public class GeneratePrimeNumber
    {
        public GeneratePrimeNumber(int quantityToGenerate)
        {
            this.QuantityToGenerate = quantityToGenerate;
        }
        
        public int QuantityToGenerate { get; set; }

        public int[] NumbersGenerated { get; private set; }

        public void Generate()
        {
            int K = 1;
            int SQUARE = 9;
            int J = 1;
            int ORD = 2;
            int[] MULT = new int[31];
            this.NumbersGenerated = new int[this.QuantityToGenerate + 1];
            int N;
            this.NumbersGenerated[1] = 2;
            bool JPRIME;
            while (K < this.QuantityToGenerate)
            {
                do
                {
                    J += 2;
                    if (J == SQUARE)
                    {
                        ORD++;
                        SQUARE = this.NumbersGenerated[ORD] * this.NumbersGenerated[ORD];
                        MULT[ORD - 1] = J;
                    }
                    N = 2;
                    JPRIME = true;
                    while (N < ORD && JPRIME)
                    {
                        while (MULT[N] < J)
                            MULT[N] += this.NumbersGenerated[N] + this.NumbersGenerated[N];
                        if (MULT[N] == J)
                            JPRIME = false;
                        N++;
                    }
                } while (!JPRIME);
                K++;
                this.NumbersGenerated[K] = J;
            }
        }
    }
}
