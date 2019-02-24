namespace Ex04.Menus.Test
{
    public class ShowVersionInterface : Interfaces.IActionMenuItem
    {
        public ShowVersionInterface()
        {
        }

        public void ActivateItem()
        {
            MenuMethods menuMethods = new MenuMethods();
            menuMethods.ShowVersion();
        }
    }
}
