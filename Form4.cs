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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wINFORMSDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wINFORMSDataSet.Специальности' table. You can move, or remove it, as needed.
            this.специальностиTableAdapter.Fill(this.wINFORMSDataSet.Специальности);
            // TODO: This line of code loads data into the 'wINFORMSDataSet.Студенты' table. You can move, or remove it, as needed.
            this.студентыTableAdapter.Fill(this.wINFORMSDataSet.Студенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wINFORMSDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }
    }
}
