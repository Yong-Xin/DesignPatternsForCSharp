﻿using System;
namespace DesignPatterns.SimpleFactory
{
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
