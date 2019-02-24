using System;

namespace Ex04.Menus.Test
{
    public class DelegateMenu
    {
        private const string                k_Version = "Version: 18.2.4.0";
        private readonly Delegates.MainMenu r_MainMenu;
        private readonly MenuMethods        r_MenuMethods;

        public DelegateMenu()
        {
            r_MainMenu = new Delegates.MainMenu("This is Delegate Main Menu");
            buildMenu();
            r_MenuMethods = new MenuMethods();
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

        private void buildMenu()
        {     
             Delegates.SubMenu        subMenuA = new Delegates.SubMenu("Show Date/Time", r_MainMenu);
             Delegates.SubMenu        subMenuB = new Delegates.SubMenu("Version and Capitals", r_MainMenu);
             Delegates.ActionMenuItem showDate = new Delegates.ActionMenuItem("Show Date", subMenuA);
             Delegates.ActionMenuItem showTime = new Delegates.ActionMenuItem("Show Time", subMenuA);
             Delegates.ActionMenuItem countCapitals = new Delegates.ActionMenuItem("Count Capitals", subMenuB);
             Delegates.ActionMenuItem showVersion = new Delegates.ActionMenuItem("Show Version", subMenuB);

             showDate.ItemActivated += this.showDate_ItemActivated;
             showTime.ItemActivated += this.showTime_ItemActivated;
             countCapitals.ItemActivated += this.countCapitals_ItemActiveted;
             showVersion.ItemActivated += this.showVersion_ItemActiveted;

             subMenuA.AddSubItem(showDate);
             subMenuA.AddSubItem(showTime);
             subMenuB.AddSubItem(countCapitals);
             subMenuB.AddSubItem(showVersion);

             r_MainMenu.AddSubItem(subMenuA);
             r_MainMenu.AddSubItem(subMenuB);
        }

        private void showTime_ItemActivated()
        {
            r_MenuMethods.ShowTime();
        }

        private void showDate_ItemActivated()
        {
            r_MenuMethods.ShowDate();
        }

        private void showVersion_ItemActiveted()
        {
            r_MenuMethods.ShowVersion();
        }

        private void countCapitals_ItemActiveted()
        {
            r_MenuMethods.CountCapitals();
        }
    }
}
