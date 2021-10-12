using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wINFORMSDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wINFORMSDataSet.Оценки' table. You can move, or remove it, as needed.
            this.оценкиTableAdapter.Fill(this.wINFORMSDataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            средний_баллTextBox.Text = Convert.ToString(((Convert.ToInt32(оценка_1TextBox.Text) + Convert.ToInt32(оценка_2TextBox.Text) + Convert.ToInt32(оценка_3TextBox.Text))/3));
        }
    }
}
