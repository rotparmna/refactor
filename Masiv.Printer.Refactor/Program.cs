namespace Masiv.Printer.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePrimeNumber generatePrimeNumber = GeneratePrimeNumbers();
            PrintPrimeNumbers(generatePrimeNumber);
        }
        
        private static GeneratePrimeNumber GeneratePrimeNumbers()
        {
            GeneratePrimeNumber generatePrimeNumber = new GeneratePrimeNumber(1000);
            generatePrimeNumber.Generate();
            return generatePrimeNumber;
        }

        private static void PrintPrimeNumbers(GeneratePrimeNumber generatePrimeNumber)
        {
            PrintMatrix printMatrix = new PrintMatrix(50, 4, generatePrimeNumber.GetNumbersGenerate());
            printMatrix.Print(generatePrimeNumber.QuantityToGenerate);
        }
    }
}
