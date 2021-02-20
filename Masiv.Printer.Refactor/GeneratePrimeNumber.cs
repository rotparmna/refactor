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
            int i = 1;
            int number = 1;
            this.NumbersGenerated = new int[this.QuantityToGenerate + 1];
            this.NumbersGenerated[1] = 2;
            while (i < this.QuantityToGenerate)
            {
                do
                {
                    number += 2;
                } while (!number.IsPrime());
                i++;
                this.NumbersGenerated[i] = number;
            }
        }
    }
}
