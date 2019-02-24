using System;

namespace Ex04.Menus.Test
{
    public class InterfaceMenu
    {
        private readonly Interfaces.MainMenu r_MainMenu;

        public InterfaceMenu()
        {
            r_MainMenu = new Interfaces.MainMenu("This is Interface Main Menu");
            buildMenu();
        }

        private void buildMenu()
        {
            Interfaces.SubMenu        subMenuA = new Interfaces.SubMenu("Show Date/Time", r_MainMenu);
            Interfaces.SubMenu        subMenuB = new Interfaces.SubMenu("Version and Capitals", r_MainMenu);
            Interfaces.ActionMenuItem showDate = new Interfaces.ActionMenuItem("Show Date", subMenuA, new ShowDateInterface());
            Interfaces.ActionMenuItem showTime = new Interfaces.ActionMenuItem("Show Time", subMenuA, new ShowTimeInterface());
            Interfaces.ActionMenuItem countCapitals = new Interfaces.ActionMenuItem("Count Capitals", subMenuB, new CountCapitalsInterface());
            Interfaces.ActionMenuItem showVersion = new Interfaces.ActionMenuItem("Show Version", subMenuB, new ShowVersionInterface());

            subMenuA.AddSubItem(showDate);
            subMenuA.AddSubItem(showTime);
            subMenuB.AddSubItem(countCapitals);
            subMenuB.AddSubItem(showVersion);

            r_MainMenu.AddSubItem(subMenuA);
            r_MainMenu.AddSubItem(subMenuB);
        }

        public void ShowMenu()
        {
            try
            {
             r_MainMenu.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
