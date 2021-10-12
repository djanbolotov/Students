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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void предметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wINFORMSDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wINFORMSDataSet.Предметы' table. You can move, or remove it, as needed.
            this.предметыTableAdapter.Fill(this.wINFORMSDataSet.Предметы);

        }
    }
}
