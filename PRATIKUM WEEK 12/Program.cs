using System;
using System.Collections.Generic;
using System.Linq;

namespace PRATIKUM_WEEK_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> newScroll = new List<string>();
           List<string> scrolls = new List<string>() {"Book of Peace", "Scroll of Swords", "Silence Guide Book" };
           var counter = 0; 
           while (true)
           {
               Console.WriteLine();
               Console.Write("1. My scroll list \n2. Add scroll \nChoose what to do : ");
               var chooseMenu = Convert.ToInt32(Console.ReadLine());
               if (chooseMenu == 1)
               {
                   Console.WriteLine();
                   counter = 0;
                   Console.WriteLine("Scroll to learn list: ");
                   foreach (var scroll in scrolls)
                   {
                       counter++;
                       Console.Write($"Scroll ke {counter} : {scroll} ");
                       Console.WriteLine();
                   }
                   Console.WriteLine();
               }
               else if (chooseMenu == 2)
               {
                   Console.WriteLine();
                   Console.WriteLine("How many scroll to add : ");
                   int howManyOfScroll = Convert.ToInt16(Console.ReadLine());
                   Console.WriteLine("In what number of queue? ");
                   int queue = Convert.ToInt16(Console.ReadLine());

                   for (int i = 0; i < howManyOfScroll; i++)
                   {
                       Console.Write("Scroll {0}" + " name : ", i + 1);
                       newScroll.Add(Console.ReadLine());
                   }

                   if (queue < 1)
                   {
                       queue = 0;
                   }
                   else if (queue > scrolls.Count())
                   {
                        queue = scrolls.Count();
                   }

                   counter = -1;
                   foreach (var scroll in newScroll)
                   {
                       scrolls.Insert(queue + counter, scroll);
                       counter++;
                   }
                   newScroll.Clear();
               }
           }
        }
    }
}
