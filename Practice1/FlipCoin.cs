using System;
namespace Practice1
{
    public class FlipCoin : Multiply // inheriting from class multiply
    {
        int count_Head = 0, count_Tail = 0;
        public void Flip()
        {

            Console.WriteLine("Enter the number of times you want to flip");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                int check = random.Next(0, 2);
                if (check == 0)
                    count_Head++;
                else
                    count_Tail++;
            }
            Console.WriteLine("Head comes {0} times ", count_Head);
            Console.WriteLine("Tail comes {0} times ", count_Tail);
            float headPercentage = ((float)count_Head / (float)num) * 100;
            Console.WriteLine("Head percentage is {0} ", headPercentage);
            float tailPercentage = ((float)count_Tail /(float) num) * 100;
            Console.WriteLine("Tail percentage is {0} ", tailPercentage);

        }
    }
}
