using System;
namespace OOPS
{
    public class HelloNew :Welcome, IHello // class Hellonew inherited from interface IHello
    {
        public void Print() // method for class HelloNew
        {
            Console.WriteLine("Hello Rahul");
        }
        public void Play() // method implementation for interface IHello
        {
            Console.WriteLine("playyy");
        }
        public override void Heyy() //method implementation for abstract class method(overriding)
        {
            Console.WriteLine("Heyy Buddy");
        }
    }
}
