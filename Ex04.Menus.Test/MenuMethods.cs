using System;

namespace Ex04.Menus.Test
{
    public class MenuMethods
    {
        private const string k_Version = "Version: 18.2.4.0";
        private const string k_ShowDetail = "The {0} is: {1}";
        private const string k_CountCapitlMsgForamt = "There Are {0} CAPITAL LETTERS in your string";

        public MenuMethods()
        {
        }

        public void ShowTime()
        {
            Console.WriteLine(k_ShowDetail, "Time", DateTime.Now.ToLongTimeString());         
        }

        public void ShowDate()
        {
            Console.WriteLine(k_ShowDetail, "Date", DateTime.Now.ToShortDateString());         
        }

        public void ShowVersion()
        {
            Console.WriteLine(k_Version);
        }

        public void CountCapitals()
        {
            string userInput;
            int    countCapitals = 0;
            Console.WriteLine("Please Enter A string");
            userInput = Console.ReadLine();

            foreach (char ch in userInput)
            {
                if ((ch >= 'A') && (ch <= 'Z'))
                {
                    countCapitals++;
                }
            }

            Console.WriteLine(k_CountCapitlMsgForamt, countCapitals);
        }
    }
}
