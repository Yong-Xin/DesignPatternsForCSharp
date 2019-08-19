using System;
namespace DesignPatterns.Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现！");
        }
    }
}
