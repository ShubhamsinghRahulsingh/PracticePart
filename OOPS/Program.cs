using OOPS;
using System;
using System.Net.Http.Headers;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Print(); // class method itself with class object
            hello.Add(4, 1); // IAdd interface method with class object
            IAdd plus = new Hello(); //object using interface 
            plus.Add(4,1);// IAdd interface method with interface object
            hello.Add(9); // interface IExplicit method with class object
            IExplicit addd = new Hello();// object using interface
            addd.Add(9);// interface IExplicit method with interface object 
            HelloNew helloNew = new HelloNew(); // new class hellonew object
            helloNew.Print();// class method with class object
            helloNew.Play();// IHello interface method using class object
            IHello print = new HelloNew();// object using IHello interface 
            print.Play();// IHello interface method
            Welcome flip = new HelloNew();// using abstract class object(implemented method in abstract class)
            flip.Flip();
            Welcome heyy = new HelloNew();// using abstrac class object( non implementing method in abstract class)
            heyy.Heyy();
            HelloNew flip1 = new HelloNew();//using class object for inherit abstract class implemented method
            flip1.Flip();
            HelloNew heyy1 = new HelloNew();// using class object for inherit abstract class non implemented method
            heyy1.Heyy();
            Hello h = new Hello();
            h.Print();
        }
    }
}