using System;
using GenericFacade.Services;

namespace GenericFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceA serviceA = new ServiceA();
            //int sAResult = serviceA.Method2();

            //ServiceB serviceB = new ServiceB();
            //string sBResult = serviceB.Method2();

            //ServiceC serviceC = new ServiceC();
            //double sCResult = serviceC.Method1();

           // Console.WriteLine(sAResult + " - " + sCResult + " - " + sBResult);

            IServiceFacade facade = new ServiceFacade();

            Tuple<int, double, string> result = facade.CallFacade();

            Console.WriteLine(result.Item1 + " - " + result.Item2 + " - " + result.Item3);

           
            
        }
    }
}