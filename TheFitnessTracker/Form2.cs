using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFitnessTracker
{
    public partial class Form2 : Form
    {

        private void LoadData()
        {
            string cs = @"server=localhost;userid=root;port=3307;password=;database=test";
            string query = "SELECT Sportág, Dátum, Időtartam, Helyszín FROM sporttev";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        Form1 mainForm;
        public Form2()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void visszaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
