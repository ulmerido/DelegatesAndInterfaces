using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class ShowTimeInterface : IActionMenuItem
    {
        public ShowTimeInterface()
        {
        }

        public void ActivateItem()
        {
            MenuMethods menuMethods = new MenuMethods();
            menuMethods.ShowTime();
        }
    }
}
