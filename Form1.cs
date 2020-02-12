using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'epadDataSet.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.epadDataSet.Information);
            // TODO: This line of code loads data into the 'your_DatabaseDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.your_DatabaseDataSet1.Student);
            // TODO: This line of code loads data into the 'your_DatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.your_DatabaseDataSet.Student);

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            informationBindingSource.AddNew();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            informationBindingSource.EndEdit();
            informationTableAdapter.Update(epadDataSet.Information);
            MessageBox.Show("NEW DATA ADDED");
        }
    }
}
