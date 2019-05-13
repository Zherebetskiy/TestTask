using System;

namespace TestTask
{
    class Program
    {   
        static void Main(string[] args)
        {            
            Console.WriteLine(StringSolution.Solution("nice", "niece"));
            Console.WriteLine(StringSolution.Solution("test", "tent"));
            Console.WriteLine(StringSolution.Solution("form", "from"));
            Console.WriteLine(StringSolution.Solution("o", "odd"));
            Console.WriteLine(StringSolution.Solution("EQUAL", "EQUAL"));
            Console.ReadKey();
        }
    }
}
