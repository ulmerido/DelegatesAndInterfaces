namespace Ex04.Menus.Delegates
{   
    public abstract class MenuItem
    {
        private readonly string      r_ItemName;
        protected readonly MenuItem  r_MenuParent;    
             
        public MenuItem(string i_ItemName, MenuItem i_MenuParent)
        {
            r_ItemName = i_ItemName;
            r_MenuParent = i_MenuParent;
        }

        public string ItemName
        {
            get
            {
                return r_ItemName;
            }
        }

        public abstract void Show();
    }
}
