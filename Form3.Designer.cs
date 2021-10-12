
namespace Students
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label наименование_предметаLabel;
            System.Windows.Forms.Label описание_предметаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.wINFORMSDataSet = new Students.WINFORMSDataSet();
            this.предметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметыTableAdapter = new Students.WINFORMSDataSetTableAdapters.ПредметыTableAdapter();
            this.tableAdapterManager = new Students.WINFORMSDataSetTableAdapters.TableAdapterManager();
            this.предметыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.предметыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_предметаTextBox = new System.Windows.Forms.TextBox();
            this.описание_предметаTextBox = new System.Windows.Forms.TextBox();
            наименование_предметаLabel = new System.Windows.Forms.Label();
            описание_предметаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wINFORMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingNavigator)).BeginInit();
            this.предметыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Предметы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wINFORMSDataSet
            // 
            this.wINFORMSDataSet.DataSetName = "WINFORMSDataSet";
            this.wINFORMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предметыBindingSource
            // 
            this.предметыBindingSource.DataMember = "Предметы";
            this.предметыBindingSource.DataSource = this.wINFORMSDataSet;
            // 
            // предметыTableAdapter
            // 
            this.предметыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.WINFORMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = this.предметыTableAdapter;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            // 
            // предметыBindingNavigator
            // 
            this.предметыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.предметыBindingNavigator.BindingSource = this.предметыBindingSource;
            this.предметыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.предметыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.предметыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.предметыBindingNavigatorSaveItem});
            this.предметыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.предметыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.предметыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.предметыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.предметыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.предметыBindingNavigator.Name = "предметыBindingNavigator";
            this.предметыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.предметыBindingNavigator.Size = new System.Drawing.Size(455, 25);
            this.предметыBindingNavigator.TabIndex = 1;
            this.предметыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // предметыBindingNavigatorSaveItem
            // 
            this.предметыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.предметыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("предметыBindingNavigatorSaveItem.Image")));
            this.предметыBindingNavigatorSaveItem.Name = "предметыBindingNavigatorSaveItem";
            this.предметыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.предметыBindingNavigatorSaveItem.Text = "Save Data";
            this.предметыBindingNavigatorSaveItem.Click += new System.EventHandler(this.предметыBindingNavigatorSaveItem_Click);
            // 
            // наименование_предметаLabel
            // 
            наименование_предметаLabel.AutoSize = true;
            наименование_предметаLabel.Location = new System.Drawing.Point(53, 159);
            наименование_предметаLabel.Name = "наименование_предметаLabel";
            наименование_предметаLabel.Size = new System.Drawing.Size(138, 13);
            наименование_предметаLabel.TabIndex = 2;
            наименование_предметаLabel.Text = "Наименование предмета:";
            // 
            // наименование_предметаTextBox
            // 
            this.наименование_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.предметыBindingSource, "Наименование предмета", true));
            this.наименование_предметаTextBox.Location = new System.Drawing.Point(197, 156);
            this.наименование_предметаTextBox.Name = "наименование_предметаTextBox";
            this.наименование_предметаTextBox.Size = new System.Drawing.Size(165, 20);
            this.наименование_предметаTextBox.TabIndex = 3;
            // 
            // описание_предметаLabel
            // 
            описание_предметаLabel.AutoSize = true;
            описание_предметаLabel.Location = new System.Drawing.Point(79, 234);
            описание_предметаLabel.Name = "описание_предметаLabel";
            описание_предметаLabel.Size = new System.Drawing.Size(112, 13);
            описание_предметаLabel.TabIndex = 4;
            описание_предметаLabel.Text = "Описание предмета:";
            // 
            // описание_предметаTextBox
            // 
            this.описание_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.предметыBindingSource, "Описание предмета", true));
            this.описание_предметаTextBox.Location = new System.Drawing.Point(197, 231);
            this.описание_предметаTextBox.Name = "описание_предметаTextBox";
            this.описание_предметаTextBox.Size = new System.Drawing.Size(165, 20);
            this.описание_предметаTextBox.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 288);
            this.Controls.Add(описание_предметаLabel);
            this.Controls.Add(this.описание_предметаTextBox);
            this.Controls.Add(наименование_предметаLabel);
            this.Controls.Add(this.наименование_предметаTextBox);
            this.Controls.Add(this.предметыBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Таблица \"Предметы\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wINFORMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingNavigator)).EndInit();
            this.предметыBindingNavigator.ResumeLayout(false);
            this.предметыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WINFORMSDataSet wINFORMSDataSet;
        private System.Windows.Forms.BindingSource предметыBindingSource;
        private WINFORMSDataSetTableAdapters.ПредметыTableAdapter предметыTableAdapter;
        private WINFORMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator предметыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton предметыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименование_предметаTextBox;
        private System.Windows.Forms.TextBox описание_предметаTextBox;
    }
}