
namespace Students
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.СтудентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WINFORMSDataSet = new Students.WINFORMSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.СтудентыTableAdapter = new Students.WINFORMSDataSetTableAdapters.СтудентыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.СтудентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WINFORMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // СтудентыBindingSource
            // 
            this.СтудентыBindingSource.DataMember = "Студенты";
            this.СтудентыBindingSource.DataSource = this.WINFORMSDataSet;
            // 
            // WINFORMSDataSet
            // 
            this.WINFORMSDataSet.DataSetName = "WINFORMSDataSet";
            this.WINFORMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.СтудентыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Students.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(651, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // СтудентыTableAdapter
            // 
            this.СтудентыTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.Text = "Отчет таблицы \"Студенты\"";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СтудентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WINFORMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource СтудентыBindingSource;
        private WINFORMSDataSet WINFORMSDataSet;
        private WINFORMSDataSetTableAdapters.СтудентыTableAdapter СтудентыTableAdapter;
    }
}