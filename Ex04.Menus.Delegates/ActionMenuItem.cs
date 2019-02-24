using System;

namespace Ex04.Menus.Delegates
{
    public delegate void ActionMenuItemClickedEventHandler();

    public class ActionMenuItem : MenuItem
    {
        public event ActionMenuItemClickedEventHandler ItemActivated;
        
        public ActionMenuItem(string i_ItemName, MenuItem i_Parent) : base(i_ItemName, i_Parent)
        {    
        }

        public override void Show()
        {
            try
            {
                Console.Clear();
                OnItemActivated();
                Console.WriteLine("Press Any Key To Go Back");
                Console.ReadLine();
                this.r_MenuParent.Show();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected virtual void OnItemActivated()
        {
            if (ItemActivated != null)
            {
                ItemActivated.Invoke();
            }
            else
            {
                throw new NullReferenceException("Item Is Null - cant Invoke It");
            }
        }
    }
}
