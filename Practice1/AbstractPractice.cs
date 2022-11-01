using System;
namespace Practice1
{
    public abstract class AbstractPractice // class using keyword abstract
    {
        public abstract void Add(int a, int b); // method using abstract keyword
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
}
