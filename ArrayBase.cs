using System;

namespace Task_33
{
    public abstract class ArrayBase : IArrayBase
    {
        public dynamic value { get; set; }

        public ArrayBase(int rows, int cols, bool fillByHand)
        {
            this.value = fillByHand ? this.FillByHand(rows, cols) : this.FillByRnd(rows, cols);
        }
        
        public abstract Array FillByHand(int rows, int cols);

        public abstract Array FillByRnd(int rows, int cols);

        public abstract float GetAverage();
    }
}