using System;
namespace OOPS
{
    public abstract class Welcome // abstract class using keyword abstract
    {
        public abstract void Heyy(); // non implementing method for abstract class welcome(keyword is used)
        public void Flip() // implementing method in abstract class (keywrd is not used)
        {
            Random random = new Random();
            Console.WriteLine("Number is : " + random.Next(10,15));
        }
    }
}
