/*
   Author's name: Robinpreet Kaur 
   Author’s student number: 301100296
   Date last Modified: 7 Aug ,2020
   Program description: 
       Generate a program in C# of BMICalcutor in metric and imperial Units in forms .
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMIcalculatorForm());
        }
    }
}
