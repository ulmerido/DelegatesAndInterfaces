using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuList : MenuItem
    {
        private readonly List<MenuItem> r_SubItems;
        private readonly int r_MenuLevel;

        public MenuList(string i_ItemName, MenuItem i_Parent) : base(i_ItemName, i_Parent)
        {
            r_SubItems = new List<MenuItem>();
            r_MenuLevel = findMenuLevel(i_Parent);
        }

        private int findMenuLevel(MenuItem i_Parent)
        {
            int level = 0;
            if (i_Parent is SubMenu)
            {
                level = ((SubMenu)i_Parent).MenuLevel() + 1;
            }

            if (i_Parent is MainMenu)
            {
                level = 1;
            }

            return level;
        }

        public int MenuLevel()
        {
            return r_MenuLevel;
        }

        public override void Show()
        {
            Console.Clear();
            Console.Write(this.ToString());
            int userinput = getUserMenuInput();
            menuAction(userinput);
        }

        public override string ToString()
        {
            int count = 1;
            string escPrint;
            StringBuilder res = new StringBuilder();
            res.AppendFormat("Menu Level: {0}{1}", r_MenuLevel, Environment.NewLine);
            res.AppendLine(this.ItemName);
            foreach (MenuItem subMenu in r_SubItems)
            {
                res.AppendFormat("{0}. {1}{2}", count, subMenu.ItemName, Environment.NewLine);
                count++;
            }

            if (this is MainMenu)
            {
                escPrint = "Exit";
            }
            else
            {
                escPrint = "Back";
            }

            res.AppendFormat("0. {0}{1}", escPrint, Environment.NewLine);
            return res.ToString();
        }

        private void menuAction(int i_UserChoise)
        {
            if (i_UserChoise == 0)
            {
                if (this is MainMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Goodby!");
                }
                else if (r_MenuParent != null)
                {
                    r_MenuParent.Show();
                }
            }
            else
            {
                r_SubItems[i_UserChoise - 1].Show();
            }
        }

        private int getUserMenuInput()
        {
            int userInput = -1;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Choose one of the option above:");
                validInput = int.TryParse(Console.ReadLine(), out userInput);
                if (!validInput || (userInput > r_SubItems.Count) || (userInput < 0))
                {
                    Console.WriteLine("Invalid Input:");
                    validInput = false;
                }
            }

            return userInput;
        }

        public void AddSubItem(MenuItem i_SubItemToAdd)
        {
            if (i_SubItemToAdd is MainMenu)
            {
                throw new FormatException("Cant Add A Main Menu");
            }
            else
            {
                r_SubItems.Add(i_SubItemToAdd);
            }
        }
    }
}
