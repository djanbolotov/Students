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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'WINFORMSDataSet.Студенты' table. You can move, or remove it, as needed.
            this.СтудентыTableAdapter.Fill(this.WINFORMSDataSet.Студенты);

            this.reportViewer1.RefreshReport();
        }
    }
}
