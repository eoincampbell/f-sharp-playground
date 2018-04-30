using System;
using FSharpPlayground;


namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            FSharpPlayground.Say.hello("Eoin");

            var x = FSharpPlayground.MultiType.myFunc(true);

            Console.WriteLine($"IsBoolChoice: {x.IsBoolChoice}");
            Console.WriteLine($"IsIntChoice: {x.IsIntChoice}");
            Console.WriteLine($"Tag: {x.Tag}");
            Console.WriteLine($"GetType: {x.GetType()}");



            var y = FSharpPlayground.MultiType.myFunc(false);

            Console.WriteLine($"IsBoolChoice: {y.IsBoolChoice}");
            Console.WriteLine($"IsIntChoice: {y.IsIntChoice}");
            Console.WriteLine($"Tag: {y.Tag}");
            Console.WriteLine($"GetType: {y.GetType()}");

            

            Console.ReadLine();
        }
    }
}
