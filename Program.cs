namespace Task_33
{
    class Program
    {
        static void Main()
        {
            IArrayBase[] array = new ArrayBase[3];
            array[0] = new Array1D(3);
            array[1] = new Array2D(3, 3);
            array[2] = new JaggedArray(3);

            foreach (ArrayBase item in array)
            {
                (item as IPrinter)?.Print();
                Console.WriteLine($"Average: {item.GetAverage()}");
                Console.WriteLine("");
            }

            Console.WriteLine("----------");

            IPrinter[] printable = new IPrinter[4];
            printable[0] = new Array1D(4);
            printable[1] = new Array2D(4, 4);
            printable[2] = new JaggedArray(4);
            printable[3] = new Week();

            foreach (IPrinter item in printable)
            {
                item.Print();
                Console.WriteLine("");
            }
        }
    }
}