using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.utils
{
    class MenuUtils
    {

        public delegate void printMenuFunction();
        public delegate bool actionFromMenuFunction();

        public static void MakeMenu(printMenuFunction printMenu, actionFromMenuFunction actionFromMenu)
        {
            bool exit = false;
            do
            {
                printMenu();
                try
                {
                    exit = actionFromMenu();
                }
                catch (Exception e)
                {
                    Utils.PrintLnErrorText($"something wrong, try again");
                }
            } while (!exit);
        }
    }
}
