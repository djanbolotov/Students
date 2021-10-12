
namespace Students
{
    partial class Form4
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label рдоителиLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label номер_зачеткиLabel;
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label очная_форма_обученияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label код_специальностиLabel;
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wINFORMSDataSet = new Students.WINFORMSDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.студентыTableAdapter = new Students.WINFORMSDataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new Students.WINFORMSDataSetTableAdapters.TableAdapterManager();
            this.специальностиTableAdapter = new Students.WINFORMSDataSetTableAdapters.СпециальностиTableAdapter();
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.рдоителиComboBox = new System.Windows.Forms.ComboBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.курсNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.очная_форма_обученияCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.код_специальностиComboBox = new System.Windows.Forms.ComboBox();
            this.специальностиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            рдоителиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            номер_зачеткиLabel = new System.Windows.Forms.Label();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            очная_форма_обученияLabel = new System.Windows.Forms.Label();
            код_специальностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wINFORMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курсNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(129, 108);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(136, 138);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 4;
            полLabel.Text = "Пол:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(77, 173);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 6;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // рдоителиLabel
            // 
            рдоителиLabel.AutoSize = true;
            рдоителиLabel.Location = new System.Drawing.Point(108, 203);
            рдоителиLabel.Name = "рдоителиLabel";
            рдоителиLabel.Size = new System.Drawing.Size(58, 13);
            рдоителиLabel.TabIndex = 8;
            рдоителиLabel.Text = "Рдоители:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(125, 236);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(111, 267);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 12;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(52, 295);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(114, 13);
            паспортные_данныеLabel.TabIndex = 14;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // номер_зачеткиLabel
            // 
            номер_зачеткиLabel.AutoSize = true;
            номер_зачеткиLabel.Location = new System.Drawing.Point(79, 325);
            номер_зачеткиLabel.Name = "номер_зачеткиLabel";
            номер_зачеткиLabel.Size = new System.Drawing.Size(87, 13);
            номер_зачеткиLabel.TabIndex = 16;
            номер_зачеткиLabel.Text = "Номер зачетки:";
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Location = new System.Drawing.Point(63, 356);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(103, 13);
            дата_поступленияLabel.TabIndex = 18;
            дата_поступленияLabel.Text = "Дата поступления:";
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(121, 387);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 20;
            группаLabel.Text = "Группа:";
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Location = new System.Drawing.Point(132, 414);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(34, 13);
            курсLabel.TabIndex = 22;
            курсLabel.Text = "Курс:";
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.wINFORMSDataSet;
            // 
            // wINFORMSDataSet
            // 
            this.wINFORMSDataSet.DataSetName = "WINFORMSDataSet";
            this.wINFORMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // очная_форма_обученияLabel
            // 
            очная_форма_обученияLabel.AutoSize = true;
            очная_форма_обученияLabel.Location = new System.Drawing.Point(39, 481);
            очная_форма_обученияLabel.Name = "очная_форма_обученияLabel";
            очная_форма_обученияLabel.Size = new System.Drawing.Size(127, 13);
            очная_форма_обученияLabel.TabIndex = 26;
            очная_форма_обученияLabel.Text = "Очная форма обучения:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Студенты\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.WINFORMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = this.специальностиTableAdapter;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.студентыBindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(446, 25);
            this.студентыBindingNavigator.TabIndex = 1;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // студентыBindingNavigatorSaveItem
            // 
            this.студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыBindingNavigatorSaveItem.Image")));
            this.студентыBindingNavigatorSaveItem.Name = "студентыBindingNavigatorSaveItem";
            this.студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.студентыBindingNavigatorSaveItem.Text = "Save Data";
            this.студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентыBindingNavigatorSaveItem_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(172, 105);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 3;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Пол", true));
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.полComboBox.Location = new System.Drawing.Point(172, 135);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(121, 21);
            this.полComboBox.TabIndex = 5;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(172, 169);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            // 
            // рдоителиComboBox
            // 
            this.рдоителиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Рдоители", true));
            this.рдоителиComboBox.FormattingEnabled = true;
            this.рдоителиComboBox.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Father, Mother",
            "Not"});
            this.рдоителиComboBox.Location = new System.Drawing.Point(172, 200);
            this.рдоителиComboBox.Name = "рдоителиComboBox";
            this.рдоителиComboBox.Size = new System.Drawing.Size(121, 21);
            this.рдоителиComboBox.TabIndex = 9;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(172, 233);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 11;
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата_поступления", true));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(172, 352);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_поступленияDateTimePicker.TabIndex = 19;
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(172, 384);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 20);
            this.группаTextBox.TabIndex = 21;
            // 
            // курсNumericUpDown
            // 
            this.курсNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Курс", true));
            this.курсNumericUpDown.Location = new System.Drawing.Point(172, 414);
            this.курсNumericUpDown.Name = "курсNumericUpDown";
            this.курсNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.курсNumericUpDown.TabIndex = 23;
            // 
            // очная_форма_обученияCheckBox
            // 
            this.очная_форма_обученияCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.студентыBindingSource, "Очная_форма_обучения", true));
            this.очная_форма_обученияCheckBox.Location = new System.Drawing.Point(172, 476);
            this.очная_форма_обученияCheckBox.Name = "очная_форма_обученияCheckBox";
            this.очная_форма_обученияCheckBox.Size = new System.Drawing.Size(104, 24);
            this.очная_форма_обученияCheckBox.TabIndex = 27;
            this.очная_форма_обученияCheckBox.Text = "checkBox1";
            this.очная_форма_обученияCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(172, 562);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 562);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 601);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Телефон", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(172, 264);
            this.maskedTextBox1.Mask = "+996(999) 00-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Паспортные_данные", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(172, 292);
            this.maskedTextBox2.Mask = "0000-000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox2.TabIndex = 36;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер_зачетки", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(172, 322);
            this.maskedTextBox3.Mask = "00000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox3.TabIndex = 37;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.wINFORMSDataSet;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(55, 601);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 39;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(297, 601);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 40;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // код_специальностиLabel
            // 
            код_специальностиLabel.AutoSize = true;
            код_специальностиLabel.Location = new System.Drawing.Point(57, 448);
            код_специальностиLabel.Name = "код_специальностиLabel";
            код_специальностиLabel.Size = new System.Drawing.Size(109, 13);
            код_специальностиLabel.TabIndex = 40;
            код_специальностиLabel.Text = "Код специальности:";
            // 
            // код_специальностиComboBox
            // 
            this.код_специальностиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код_специальности", true));
            this.код_специальностиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.студентыBindingSource, "Код_специальности", true));
            this.код_специальностиComboBox.DataSource = this.специальностиBindingSource1;
            this.код_специальностиComboBox.DisplayMember = "Наименование специальности";
            this.код_специальностиComboBox.FormattingEnabled = true;
            this.код_специальностиComboBox.Location = new System.Drawing.Point(172, 445);
            this.код_специальностиComboBox.Name = "код_специальностиComboBox";
            this.код_специальностиComboBox.Size = new System.Drawing.Size(121, 21);
            this.код_специальностиComboBox.TabIndex = 41;
            this.код_специальностиComboBox.ValueMember = "Код специальности";
            // 
            // специальностиBindingSource1
            // 
            this.специальностиBindingSource1.DataMember = "Специальности";
            this.специальностиBindingSource1.DataSource = this.wINFORMSDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 644);
            this.Controls.Add(код_специальностиLabel);
            this.Controls.Add(this.код_специальностиComboBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(очная_форма_обученияLabel);
            this.Controls.Add(this.очная_форма_обученияCheckBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсNumericUpDown);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(номер_зачеткиLabel);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(рдоителиLabel);
            this.Controls.Add(this.рдоителиComboBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Таблица \"Студенты\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wINFORMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курсNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WINFORMSDataSet wINFORMSDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private WINFORMSDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private WINFORMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.ComboBox рдоителиComboBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.NumericUpDown курсNumericUpDown;
        private System.Windows.Forms.CheckBox очная_форма_обученияCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private WINFORMSDataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox код_специальностиComboBox;
        private System.Windows.Forms.BindingSource специальностиBindingSource1;
    }
}