using System;
using System.Collections.Generic;
using System.Linq;

namespace StringChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Chat");
            string clientChat = Console.ReadLine();
            string name = getName(clientChat);
            int[] menu = getMenu(clientChat);
            Console.WriteLine(name);
            foreach (int c in menu)
                Console.WriteLine(c);
        }

        static string getName(string clientChat)
        {
            int indexSpace = clientChat.IndexOf(" ");
            string name = clientChat.Remove(indexSpace);
            return name;
        }

        static int[] getMenu(string clientChat)
        {
            int[] menuList = { };
            int indexSpace = clientChat.IndexOf(" ");
            string menu = clientChat.Remove(0, indexSpace + 1);
            int menuCount = menu.Count(x => x == ',');
            for (int i = 0; i < menuCount; i++)
            {
                int indexMenu = menu.IndexOf("-");
                string Mnu = menu.Remove(indexMenu);
                int IDMenu = Convert.ToInt32(Mnu);
                menuList = menuList.Append(IDMenu).ToArray();
                string amount = menu.Remove(0, 2);
                int indexComma = amount.IndexOf(",");
                string amount2 = amount.Remove(indexComma);
                int amount3 = Convert.ToInt32(amount2);
                menuList = menuList.Append(amount3).ToArray();
                menu = amount.Remove(0, 2);
            }
            return menuList;
        }
    }
}
