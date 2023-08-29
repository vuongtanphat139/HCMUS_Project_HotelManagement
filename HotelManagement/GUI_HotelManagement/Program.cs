using HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HotelManagement
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
  
            Application.Run(new Dashboard_GUI());
=======
            Application.Run(new Checkout_Form());
            //Application.Run(new Reservation());
            //Application.Run(new Edit_Resevation());
>>>>>>> Stashed changes
        }
    }
}
