using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Display
    {
        public void BuildMenu(string menuMessage, string menuOptions)
        {
            Console.Clear();
            Console.WriteLine(menuMessage);
            Console.WriteLine(menuOptions);
        }
    }
}
