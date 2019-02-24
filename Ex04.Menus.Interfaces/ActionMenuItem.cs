using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly IActionMenuItem r_ActionItem;

        public ActionMenuItem(string i_ItemName, MenuItem i_Parent, IActionMenuItem i_ActionItem) : base(i_ItemName, i_Parent)
        {
            r_ActionItem = i_ActionItem;
        }

        public override void Show()
        {
            Console.Clear();
            if (r_ActionItem != null)
            {
                r_ActionItem.ActivateItem();
            }
            else
            {
                throw new NullReferenceException("Item is Null cant Invoke!");
            }

            Console.WriteLine("Press Any Key To Go Back");
            Console.ReadLine();
            this.r_MenuParent.Show();
        }
    }
}
