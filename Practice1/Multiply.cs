using System;
namespace Practice1
{
    public class Multiply : AbstractPractice  // inherit
    {
        public  override void Add(int a, int b) // implementation for abstract class
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Into(int x, int y) // simple method with parameters passed for class multiply
        {
            int z = x * y;
            Console.WriteLine(z);
        }
    }
}
