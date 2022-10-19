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
                    for (int j = 0; j <= 99; j += 3)
                    {
                        allChicken = i + k + j;
                        money = i * 5 + k * 3 + j/3;
                        if(money == 100 && allChicken == 100)
                        {
                            Console.WriteLine($"母雞{i}隻公雞{k}隻小雞{j}隻");
                        }
                    }
                }
            }

        }
    }
}
