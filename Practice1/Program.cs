using System;
namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice add = new Practice(); // object for class
            add.Add(3,4); // calling from class practice
            IPractice add1 = new Practice(); // using interface varibale
            add1.Add(2,3); // from interface IPractice as IPractice is inherited into practice
            FlipCoin flip = new FlipCoin(); // object for class flipcoin
            flip.Flip(); // from class FlipCoin
            flip.Into(4,5); // from class Multiply using inheritance
            Multiply add3 = new Multiply(); //using inherited multiply class
            add3.Add(3,4);
            AbstractPractice add4 = new Multiply(); // using abstract class which is inherited
            add4.Add(2,3);
            AbstractPractice add5 = new Multiply(); 
            add5.Sub(10, 3); // calling second method from abstract class which is implemented


        }
    }
}
