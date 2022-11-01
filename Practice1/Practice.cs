using System;
namespace Practice1
{
    public class Practice : IPractice // inherited class practice from interface IPractice
    {
        public void Add(int a, int b) // should have same method name as interface
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
