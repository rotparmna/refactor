namespace Masiv.Printer.Refactor
{
    using System;

    public class PrintMatrix
    {
        private const string TITLEPAGE = "The First {0} Prime Numbers === Page {1}";
        private readonly int[] content;
        private int totalCellsToPrint;
        private int pageOffset;
        private int pageNumber;

        public PrintMatrix(int quantityRows, int quantityColumns, int[] content)
        {
            this.QuantityColumns = quantityColumns;
            this.QuantityRows = quantityRows;
            this.content = content;
        }

        public int QuantityRows { get; set; }
        
        public int QuantityColumns { get; set; }

        public void Print(int totalCellsToPrint)
        {
            this.totalCellsToPrint = totalCellsToPrint;
            this.pageOffset = 1;
            this.pageNumber = 1;
            while (this.pageOffset <= this.totalCellsToPrint)
            {
                this.PrintPage();
            }
        }

        private void PrintPage()
        {
            Console.WriteLine(string.Format(TITLEPAGE, this.totalCellsToPrint, this.pageNumber));
            Console.WriteLine("\n");
            for (int rowOffset = this.pageOffset; rowOffset <= (this.pageOffset + this.QuantityRows - 1); rowOffset++)
            {
                this.PrintCell(rowOffset);
                Console.WriteLine();
            }
            Console.WriteLine("\f");
            this.pageNumber++;
            this.pageOffset += this.QuantityRows * this.QuantityColumns;
        }

        private void PrintCell(int rowOffset)
        {
            for (int i = 0; i <= this.QuantityColumns - 1; i++)
                if ((rowOffset + i * this.QuantityRows) <= this.totalCellsToPrint)
                    Console.Write(this.content[rowOffset + i * this.QuantityRows].ToString().PadLeft(10));
        }
    }
}
