using System;
namespace DesignPatterns.Strategy
{
    public class Context
    {
        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 上下文接口
        /// </summary>
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
