using System;
namespace DesignPatterns.Strategy
{
    public class ConcreteStrategyC:Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现！");
        }
    }
}
