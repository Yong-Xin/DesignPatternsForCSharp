using System;
namespace DesignPatterns.Strategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现！");
        }
    }
}
