using DesignPatterns.Iterator;
using DesignPatterns.Iterator.IteratorForDotNet;
using DesignPatterns.SimpleFactory;
using DesignPatterns.Strategy;
using System;

namespace ConsolePro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*********************Simple Factory Start*************************/
            //Operation oper;
            //oper = OperationFactory.CreateOperation("+");
            //oper.NumberA = 1;
            //oper.NumberB = 2;
            //double result = oper.GetResult();
            //Console.WriteLine(result);
            /*********************Simple Factory End*************************/

            /*********************Iterator Start*************************/
            //ConcreteAggregate a = new ConcreteAggregate();
            //a[0] = "a";
            //a[1] = "b";
            //a[2] = "c";
            //a[3] = "d";
            //a[4] = "e";

            //Iterator i = new ConcreteIteratorDesc(a);
            ////Iterator i = a.CreateIterator();
            //object item = i.First();
            //while (!i.IsDone())
            //{
            //    Console.WriteLine($"{i.CurrentItem()}");
            //    i.Next();
            //}

            //Iterator For DotNet

            //Student[] studentArray = new Student[4];
            //studentArray[0] = new Student("Rusty", "man");
            //studentArray[1] = new Student("Clunker", "man");
            //studentArray[2] = new Student("Zippy", "man");
            //studentArray[3] = new Student("Fred", "man");
            //var studentList = new StudentList(studentArray);
            //foreach (Student s in studentList)
            //{
            //    Console.WriteLine(s.Name);
            //}
            /*********************Iterator end*************************/

            /*********************Strategy Start*************************/
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            ContextSimpleFactory contextSimpleFactory = new ContextSimpleFactory("A");
            contextSimpleFactory.ContextInterface();

            /*********************Strategy End*************************/
        }
    }
}
