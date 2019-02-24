using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateInterface : IActionMenuItem
    {
        public ShowDateInterface()
        {
        }

        public void ActivateItem()
        {
            MenuMethods menuMethods = new MenuMethods();
            menuMethods.ShowDate();
        }
    }
}
