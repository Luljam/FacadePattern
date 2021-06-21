using System;
using BallOfMud.Services;

namespace BallOfMud
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original instance

            //BigClass bigClass = new BigClass();

            //bigClass.SetValueI(3);

            //bigClass.IncrementI();
            //bigClass.IncrementI();
            //bigClass.IncrementI();

            //bigClass.DecrememntI();

            //Console.WriteLine($"Final Number : {bigClass.GetValueB()}");

            BigClassFacade bigClass = new BigClassFacade();
            bigClass.IncreaseBy(50);
            bigClass.DecreaseBy(30);
            Console.WriteLine($"Final number : {bigClass.GetCurrentValue()}");
        }
    }
}