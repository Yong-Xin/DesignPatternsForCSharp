using System;
namespace DesignPatterns.SimpleFactory
{
    public class Operation
    {
        public double NumberA { get; set; } = 0;

        public double NumberB { get; set; } = 0;

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}