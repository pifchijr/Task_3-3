using System;

namespace Task_33
{
    sealed public class Array1D : ArrayBase, IPrinter, IDeduplicatable
    {
        public Array1D(int length, bool fillByHand = false) : base(1, length, fillByHand) {}

        public override int[] FillByHand(int rows, int cols) 
        {
            Console.WriteLine("Пишите элементы по очереди");
            int[] array = new int[cols];
            string? input;
            for (int i = 0; i < array.Length; i++)
            {
                input = Console.ReadLine();
                array[i] = string.IsNullOrEmpty(input) ? 0 : int.Parse(input);
            }
            return array;
        }

        public override int[] FillByRnd(int rows, int cols)
        {
            int[] array = new int[cols];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", this.value));
        }

        public override float GetAverage()
        {
            float sum = 0;
            for (int i = 0; i < this.value.Length; i++)
            {
                sum += this.value[i];
            }
            return sum / this.value.Length;
        }

        public void Deduplicate()
        {
            List<int> list = [];
            foreach (int item in this.value)
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
        }
    }
}