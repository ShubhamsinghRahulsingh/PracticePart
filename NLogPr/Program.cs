using System;
namespace NLogPr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the numbers");
            AddNumbersPr add = new AddNumbersPr();
            Console.WriteLine("Result is: "+add.Addition(0,1));
        }
    }
}
