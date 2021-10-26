using System;

namespace Phase1Section6._9JRH
{
    public class MyPackage
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public void DisplayDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

    }
}
