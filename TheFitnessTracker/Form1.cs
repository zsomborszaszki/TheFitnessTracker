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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void felvitelButton_Click(object sender, EventArgs e)
        {
            string aktSportag = sportagCombo.Text;
            decimal aktIdotartam = idotartamNumeric.Value;
            var aktDatum = datumDateTime.Value;
            var aktHelyszin = helyszinText.Text;
        }

        private void helyszinText_TextChanged(object sender, EventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
