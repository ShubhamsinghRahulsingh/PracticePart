using System;
namespace OOPS
{
    public class CouponNumber
    {
        static int Count = 0;
        public static int GenerateRandom()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            Count++;
            return randomNum;
        }
        public static void GenerateCoupons(int num)
        {
            int[] coupons = new int[num];
            for (int i = 0; i < coupons.Length; i++)
            {
                int number = 0;
                int random = GenerateRandom();
                foreach(int j in coupons)
                {
                    if (j == random)
                    {
                        number++;
                    }
                }
                if (number == 0)
                {
                    coupons[i] = random;
                }
                else
                {
                    i -= 1;
                }
            }
            foreach (int j in coupons)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("{0} random numbers are needed to have 10 distinct coupon numbers:", Count);

        }
    }
}
