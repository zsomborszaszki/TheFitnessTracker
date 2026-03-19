using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFitnessTracker
{

    public partial class Form1 : Form
    {
        public void CsvImport()
        {
            string path = Path.Combine(Application.StartupPath, "import.csv");

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                string sportag = parts[0];
                DateTime datum = DateTime.Parse(parts[1]);
                decimal idotartam = decimal.Parse(parts[2]);
                string helyszin = parts[3];

                InsertDatas(sportag, idotartam, datum, helyszin);
            }

            MessageBox.Show("Az Importálás Befejeződött!");
        }

        public void CsvExport()
        {
            string cs = @"server=localhost;userid=root;port=3307;password=;database=test";
            string query = "SELECT Sportág, Dátum, Időtartam, Helyszín FROM sporttev";

            using (MySqlConnection con = new MySqlConnection(cs))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                con.Open();
                string path = Path.Combine(Application.StartupPath, "export.csv");


                using (MySqlDataReader reader = cmd.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine(
                            "Sportág, Dátum, Időtartam, Helyszín"
                        );
                    while (reader.Read())
                    {
                        writer.WriteLine(
                            $"{reader["Sportág"]},{reader["Dátum"]},{reader["Időtartam"]},{reader["Helyszín"]}"
                        );
                    }
                }
            }

            MessageBox.Show("Az Exportálás Befejeződött!");
        }
        public void InsertDatas(string aktSportag, decimal aktIdotartam, DateTime aktDatum, string aktHelyszin)
        {
            string cs = @"server=localhost;userid=root;port=3307;password=;database=test";
            string query = "INSERT INTO sporttev(Sportág,Dátum,Időtartam,Helyszín) VALUES (@sportag,@datum,@idotartam,@helyszin)";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sportag", aktSportag);
                    cmd.Parameters.AddWithValue("@datum", aktDatum);
                    cmd.Parameters.AddWithValue("@idotartam", aktIdotartam);
                    cmd.Parameters.AddWithValue("@helyszin", aktHelyszin);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        public void felvitelButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sportagCombo.Text))
            {
                MessageBox.Show("A sportág megadása kötelező!");
                return;
            }

            if (string.IsNullOrWhiteSpace(helyszinText.Text))
            {
                MessageBox.Show("A helyszín megadása kötelező!");
                return;
            }

            if (idotartamNumeric.Value <= 0)
            {
                MessageBox.Show("Az időtartamnak nagyobbnak kell lennie mint 0!");
                return;
            }

            string aktSportag = sportagCombo.Text;
            decimal aktIdotartam = idotartamNumeric.Value;
            var aktDatum = datumDateTime.Value;
            var aktHelyszin = helyszinText.Text;

            InsertDatas(aktSportag,aktIdotartam, aktDatum, aktHelyszin);

            MessageBox.Show("Tevékenység rögzítve!");

            sportagCombo.SelectedIndex = -1;
            idotartamNumeric.Value = 0;
            datumDateTime.Value = DateTime.Now;
            helyszinText.Clear();
        }

        private void helyszinText_TextChanged(object sender, EventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            CsvImport();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            CsvExport();
        }

        private void adatokButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            this.Hide();
            f2.ShowDialog(this);
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
