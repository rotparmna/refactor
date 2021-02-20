namespace Masiv.Printer.Refactor
{
    public class GeneratePrimeNumber
    {
        private int[] numbersGenerated;
        public GeneratePrimeNumber(int quantityToGenerate)
        {
            this.QuantityToGenerate = quantityToGenerate;
        }
        
        public int QuantityToGenerate { get; set; }

        public void Generate()
        {
            int i = 1;
            int number = 1;
            this.numbersGenerated = new int[this.QuantityToGenerate + 1];
            this.numbersGenerated[1] = 2;
            while (i < this.QuantityToGenerate)
            {
                do
                {
                    number += 2;
                } while (!number.IsPrime());
                i++;
                this.numbersGenerated[i] = number;
            }
        }

        public int[] GetNumbersGenerate()
        {
            return (int[])this.numbersGenerated.Clone();
        }
    }
}
