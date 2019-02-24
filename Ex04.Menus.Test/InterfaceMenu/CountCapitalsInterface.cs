using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitalsInterface : IActionMenuItem
    {
        public CountCapitalsInterface()
        {
        }

        public void ActivateItem()
        {
            MenuMethods menuMethods = new MenuMethods();
            menuMethods.CountCapitals();
        }
    }
}
