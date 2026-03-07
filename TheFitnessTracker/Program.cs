using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace TheFitnessTracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);




            string cs = @"server=localhost;userid=root;port=3307;password=;database=test";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS sportTev(ID INT AUTO_INCREMENT PRIMARY KEY ,Sportág TEXT, Dátum DateTime, Időtartam INT, Helyszín TEXT)";
                cmd.ExecuteNonQuery();
            }

            Application.Run(new Form1());

            
        }
    }
}
