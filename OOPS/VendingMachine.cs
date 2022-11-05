using System;
namespace OOPS
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        int count = 0,flag;
        public void Change(int amount)//5700,4700,3700,2700,1700,700,200,100
        {
            int i = 0;
            while (i < notes.Length)//
            {
                if (amount / notes[i] >= 1)
                {
                    Console.WriteLine("Change of amount is: " + notes[i]);//1000,1000,1000,1000,1000,500,100,100
                    count++;
                    amount -= notes[i];//4700,3700,2700,1700,700,200,100,0
                    if (amount != 0)
                    {
                        this.Change(amount);
                    }
                    else
                        i = notes.Length;
                        Console.WriteLine("Number of notes required is: " + count);
                        return;
                }
                else
                    i++;
                    continue;
            }
        }
    }
}
