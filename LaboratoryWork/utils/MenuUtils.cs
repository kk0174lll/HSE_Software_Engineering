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
        public delegate void actionFromMenuFunction(int action, ref bool exit);

        public static void MakeMenu(printMenuFunction printMenu, actionFromMenuFunction actionFromMenu)
        {
            bool exit = false;
            do
            {
                printMenu();
                try
                {
                    int action = Utils.ReadInt("number of action");
                    actionFromMenu(action, ref exit);
                }
                catch (Exception e)
                {
                    Utils.PrintLnErrorText($"something wrong ({e.Message}), try again");
                }
            } while (!exit);
        }
    }
}
