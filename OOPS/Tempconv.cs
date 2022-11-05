using System;
namespace OOPS
{
    public class Tempconv
    {
        public static void CelsToFahr(int cels)
        {
            float fahr = (cels * (9 / 5f)) + 32;
            Console.WriteLine("{0}C into fahrenheit is {1}F",cels,fahr);
        }
        public static void FahrToCels(int fahr)
        {
            float cel = (fahr - 32) * (5 / 9f);
            Console.WriteLine("{0}F into Celsius is {1}C",fahr,cel);
        }
    }
}
