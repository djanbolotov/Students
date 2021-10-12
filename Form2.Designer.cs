
namespace Students
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label наименование_специальностиLabel;
            System.Windows.Forms.Label описание_специальностиLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.wINFORMSDataSet = new Students.WINFORMSDataSet();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиTableAdapter = new Students.WINFORMSDataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new Students.WINFORMSDataSetTableAdapters.TableAdapterManager();
            this.специальностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.специальностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.описание_специальностиTextBox = new System.Windows.Forms.TextBox();
            наименование_специальностиLabel = new System.Windows.Forms.Label();
            описание_специальностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wINFORMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingNavigator)).BeginInit();
            this.специальностиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(99, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Специальности\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wINFORMSDataSet
            // 
            this.wINFORMSDataSet.DataSetName = "WINFORMSDataSet";
            this.wINFORMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.wINFORMSDataSet;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.WINFORMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = this.специальностиTableAdapter;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            // 
            // специальностиBindingNavigator
            // 
            this.специальностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.специальностиBindingNavigator.BindingSource = this.специальностиBindingSource;
            this.специальностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.специальностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.специальностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.специальностиBindingNavigatorSaveItem});
            this.специальностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.специальностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.специальностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.специальностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.специальностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.специальностиBindingNavigator.Name = "специальностиBindingNavigator";
            this.специальностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.специальностиBindingNavigator.Size = new System.Drawing.Size(477, 25);
            this.специальностиBindingNavigator.TabIndex = 1;
            this.специальностиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // специальностиBindingNavigatorSaveItem
            // 
            this.специальностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.специальностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("специальностиBindingNavigatorSaveItem.Image")));
            this.специальностиBindingNavigatorSaveItem.Name = "специальностиBindingNavigatorSaveItem";
            this.специальностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.специальностиBindingNavigatorSaveItem.Text = "Save Data";
            this.специальностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.специальностиBindingNavigatorSaveItem_Click);
            // 
            // наименование_специальностиLabel
            // 
            наименование_специальностиLabel.AutoSize = true;
            наименование_специальностиLabel.Location = new System.Drawing.Point(74, 126);
            наименование_специальностиLabel.Name = "наименование_специальностиLabel";
            наименование_специальностиLabel.Size = new System.Drawing.Size(166, 13);
            наименование_специальностиLabel.TabIndex = 2;
            наименование_специальностиLabel.Text = "Наименование специальности:";
            // 
            // наименование_специальностиTextBox
            // 
            this.наименование_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.специальностиBindingSource, "Наименование специальности", true));
            this.наименование_специальностиTextBox.Location = new System.Drawing.Point(246, 123);
            this.наименование_специальностиTextBox.Name = "наименование_специальностиTextBox";
            this.наименование_специальностиTextBox.Size = new System.Drawing.Size(148, 20);
            this.наименование_специальностиTextBox.TabIndex = 3;
            // 
            // описание_специальностиLabel
            // 
            описание_специальностиLabel.AutoSize = true;
            описание_специальностиLabel.Location = new System.Drawing.Point(100, 201);
            описание_специальностиLabel.Name = "описание_специальностиLabel";
            описание_специальностиLabel.Size = new System.Drawing.Size(140, 13);
            описание_специальностиLabel.TabIndex = 4;
            описание_специальностиLabel.Text = "Описание специальности:";
            // 
            // описание_специальностиTextBox
            // 
            this.описание_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.специальностиBindingSource, "Описание специальности", true));
            this.описание_специальностиTextBox.Location = new System.Drawing.Point(246, 198);
            this.описание_специальностиTextBox.Name = "описание_специальностиTextBox";
            this.описание_специальностиTextBox.Size = new System.Drawing.Size(148, 20);
            this.описание_специальностиTextBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 274);
            this.Controls.Add(описание_специальностиLabel);
            this.Controls.Add(this.описание_специальностиTextBox);
            this.Controls.Add(наименование_специальностиLabel);
            this.Controls.Add(this.наименование_специальностиTextBox);
            this.Controls.Add(this.специальностиBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Табица \"Специальности\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wINFORMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingNavigator)).EndInit();
            this.специальностиBindingNavigator.ResumeLayout(false);
            this.специальностиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WINFORMSDataSet wINFORMSDataSet;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private WINFORMSDataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private WINFORMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator специальностиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton специальностиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименование_специальностиTextBox;
        private System.Windows.Forms.TextBox описание_специальностиTextBox;
    }
}