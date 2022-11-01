using System;
namespace OOPS
{
    public class Hello : IAdd, IExplicit // class hello inherited from 2 interface 
    {
        public void Print() // method for class hello
        {
            Console.WriteLine("Hello Shubham");
        }
        public void Add(int a, int b) // method implementation for interfce IAdd
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a) //method implementation for interface IExplicit
        {
            int d = a;
            Console.WriteLine(d);
        }
    
    }
}
