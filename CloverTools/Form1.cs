using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloverTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Edit(bool value)
        {
            textLastname.Enabled = value;
            textName.Enabled = value;
            textProductionLine.Enabled = value;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.proba' table. You can move, or remove it, as needed.
            this.probaTableAdapter.Fill(this.testDataSet.proba);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                testDataSet.proba.AddprobaRow(testDataSet.proba.NewprobaRow());
                probaBindingSource.MoveLast();
                textName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Ovde zapinje");
                testDataSet.proba.RejectChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            textName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit(false);
            probaBindingSource.ResetBindings(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                probaBindingSource.EndEdit();
                probaTableAdapter.Update(testDataSet.proba);
                dataGridView1.Refresh();
                textName.Focus();
                MessageBox.Show("Sačuvano");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Ovde zapinje");
                testDataSet.proba.RejectChanges();
            }
        }
    }
}
