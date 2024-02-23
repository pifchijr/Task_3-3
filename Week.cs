using System;

namespace Task_33
{
    public class Week : IPrinter
    {
        public Week() {}

        public void Print()
        {
            Console.WriteLine("Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday");
        }
    }
}