using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //題目：百元買百雞　想用一百元買剛好一百隻雞，公雞５元，母雞３元，小雞三隻１元。
            int cock = 5;
            int hen = 3;
            int chicken = 1;//3隻一塊錢
            int allChicken = 0;
            int money = 0;

            for (int i = 0; i <= 20; i++)
            {
                for (int k = 0; k <= 33; k++)
                {
                    chicken = 100 - i - k;
                    allChicken = i + k + chicken;
                    if (chicken % 3 != 0)
                    {
                        continue;
                    }
                    money = i * 5 + k * 3 + chicken / 3;
                    if (money == 100 && allChicken == 100)
                    {
                        Console.WriteLine($"母雞 {i} 隻公雞 {k} 隻小雞 {chicken} 隻");
                    }
                }
            }

            //母雞0隻公雞25隻小雞75隻
            //母雞4隻公雞18隻小雞78隻
            //母雞8隻公雞11隻小雞81隻
            //母雞12隻公雞4隻小雞84隻

        }
    }
}
