using System;
using System.Collections.Generic;
using System.Linq;

namespace StringChat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> OrderList = new List<string[]>
            {
                new string[] {"name","menu" }
            };

            string clientChat = "Joker 0-3,1-1,3-2,";
            int indexSpace = clientChat.IndexOf(" ");
            string name = clientChat.Remove(indexSpace);
            string menu = clientChat.Remove(0, indexSpace + 1);
            OrderList.Add(new string[] { name, menu });
            Console.WriteLine(name);
            MenuQuery(menu);
            //foreach(string k in OrderList[1])
            //    Console.WriteLine(k);
        }

        static void MenuQuery(string menu)
        {
            int menuCount = menu.Count(x => x == ',');
            for (int i = 0; i < menuCount; i++)
            {
                int indexMenu = menu.IndexOf("-");
                string Mnu = menu.Remove(indexMenu);
                int IDMenu = Convert.ToInt32(Mnu);
                string amount = menu.Remove(0, 2);
                int indexComma = amount.IndexOf(",");
                string amount2 = amount.Remove(indexComma);
                int amount3 = Convert.ToInt32(amount2);
                menu = amount.Remove(0, 2);
                Console.WriteLine(IDMenu);
                Console.WriteLine(amount3);
            }
        }
    }
}
