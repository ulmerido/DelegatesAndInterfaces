using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuList
    {
        public SubMenu(string i_ItemName, MenuList i_Parent) : base(i_ItemName, i_Parent)
        {
        }
    }
}
