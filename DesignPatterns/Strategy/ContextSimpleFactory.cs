using System;
namespace DesignPatterns.Strategy
{
    public class ContextSimpleFactory
    {
        private readonly Strategy strategy;

        public ContextSimpleFactory(string type)
        {
            switch(type)
            {
                case "A":
                    Strategy strategy0 = new ConcreteStrategyA();
                    strategy = strategy0;
                    break;
                case "B":
                    Strategy strategy1 = new ConcreteStrategyB();
                    strategy = strategy1;
                    break;
                case "C":
                    Strategy strategy2 = new ConcreteStrategyC();
                    strategy = strategy2;
                    break;
            }
        }

        /// <summary>
        /// 上下文接口
        /// </summary>
        public void ContextInterface()
        {
            strategy?.AlgorithmInterface();
        }
    }
}
