using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                InterfaceMenu interfaceMenu = new InterfaceMenu();
                DelegateMenu  delegateMenu = new DelegateMenu();
                interfaceMenu.ShowMenu();
                delegateMenu.ShowMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
