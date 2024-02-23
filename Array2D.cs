using System;

namespace Task_33
{
    sealed public class Array2D : ArrayBase, IPrinter, IPrinterSnake
    {
        public Array2D(int rows, int cols, bool fillByHand = false) : base(rows, cols, fillByHand) {}

        public override int[,] FillByHand(int rows, int cols)
        {
            Console.WriteLine("Введите элементы матрицы построчно через пробел:");
            this.value = new int[rows, cols];
            string? input;
            string[] inputArray;
            for (int row = 0; row < rows; row++)
            {
                Console.Write($"Строка {row + 1}: ");
                input = Console.ReadLine() ?? "";
                inputArray = input.Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    this.value[row, col] = col < inputArray.Length
                        ? Convert.ToInt32(inputArray[col]) : 0;
                }
            }
            return this.value;
        }

        public override int[,] FillByRnd(int rows, int cols)
        {
            this.value = new int[rows, cols];
            Random rnd = new Random();
            for (int row = 0; row < this.value.GetLength(0); row++)
            {
                for (int col = 0; col < this.value.GetLength(1); col++)
                {
                    this.value[row, col] = rnd.Next(-100, 100);
                }
            }
            return this.value;
        }

        public void Print()
        {
            for (int row = 0; row < this.value.GetLength(0); row++)
            {
                for (int col = 0; col < this.value.GetLength(1); col++)
                {
                    Console.Write(Leading(this.value[row, col]));
                }
                Console.WriteLine("");
            }
        }

        public void PrintSnake()
        {
            for (int row = 0; row < this.value.GetLength(0); row++)
            {
                for (int col = 0; col < this.value.GetLength(1); col++)
                {
                    Console.Write(Leading(this.value[
                        row, 
                        row % 2 != 0 ? this.value.GetLength(1) - col - 1 : col
                    ]));
                }
                Console.WriteLine("");
            }
        }

        public static string Leading(int n)
        {
            string temp = ("     " + n);
            return temp.Substring(temp.Length - 6);
        }

        public override float GetAverage()
        {
            float sum = 0;
            for (int row = 0; row < this.value.GetLength(0); row++)
            {
                for (int col = 0; col < this.value.GetLength(1); col++)
                {
                    sum += this.value[row, col];
                }
            }
            return sum / (this.value.GetLength(0) * this.value.GetLength(1));
        }
    }
}