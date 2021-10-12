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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wINFORMSDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wINFORMSDataSet.Студенты' table. You can move, or remove it, as needed.
            this.студентыTableAdapter.Fill(this.wINFORMSDataSet.Студенты);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn col = dataGridViewTextBoxColumn2;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    col = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    col = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    col = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    col = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    col = dataGridViewTextBoxColumn10;
                    break;
                case 9:
                    col = dataGridViewTextBoxColumn11;
                    break;
                case 10:
                    col = dataGridViewTextBoxColumn12;
                    break;
                default:
                    break;
            }
            if (radioButton1.Checked)
            {
                студентыDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                студентыDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = $"ФИО='{comboBox1.Text}'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < студентыDataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < студентыDataGridView.Rows.Count; j++)
                {
                    студентыDataGridView[i, j].Style.BackColor = Color.White;
                    студентыDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < студентыDataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < студентыDataGridView.Rows.Count; j++)
                {
                    if (Convert.ToString(студентыDataGridView[i, j].Value) == textBox1.Text)
                    {
                        студентыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        студентыDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
