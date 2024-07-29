namespace XMLtoExcel.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.labelNameExcelStock = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.listViewExcelStock = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.memoOutExcelStock = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuLogger = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIsInterop = new System.Windows.Forms.CheckBox();
            this.checkIsEpplus = new System.Windows.Forms.CheckBox();
            this.checkIsDeleteColumnNumber = new System.Windows.Forms.CheckBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtPricePerSet = new System.Windows.Forms.TextBox();
            this.checkPricePerSet = new System.Windows.Forms.CheckBox();
            this.txtListNameStock = new System.Windows.Forms.TextBox();
            this.txtListNameO = new System.Windows.Forms.TextBox();
            this.txtListNameY = new System.Windows.Forms.TextBox();
            this.checkO = new System.Windows.Forms.CheckBox();
            this.checkY = new System.Windows.Forms.CheckBox();
            this.checkStock = new System.Windows.Forms.CheckBox();
            this.txtPercentExcelO = new System.Windows.Forms.TextBox();
            this.txtAddNewPriceExcelO = new System.Windows.Forms.TextBox();
            this.txtAddCurrentPriceExcelO = new System.Windows.Forms.TextBox();
            this.txtCurrentPriceExcelO = new System.Windows.Forms.TextBox();
            this.txtArticuleExcelO = new System.Windows.Forms.TextBox();
            this.label1labelNameExcelO = new System.Windows.Forms.Label();
            this.memoOutExcelO = new System.Windows.Forms.RichTextBox();
            this.listViewExcelO = new System.Windows.Forms.ListView();
            this.txtPercentExcelY = new System.Windows.Forms.TextBox();
            this.txtAddNewPriceExcelY = new System.Windows.Forms.TextBox();
            this.txtAddCurrentPriceExcelY = new System.Windows.Forms.TextBox();
            this.txtCurrentPriceExcelY = new System.Windows.Forms.TextBox();
            this.txtArticuleExcelY = new System.Windows.Forms.TextBox();
            this.labelNameExcelY = new System.Windows.Forms.Label();
            this.memoOutExcelY = new System.Windows.Forms.RichTextBox();
            this.listViewExcelY = new System.Windows.Forms.ListView();
            this.menuStrip.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(94, 98);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.MinimumSize = new System.Drawing.Size(300, 4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(486, 37);
            this.txtPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(583, 98);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(34, 37);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "+";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // labelNameExcelStock
            // 
            this.labelNameExcelStock.AutoSize = true;
            this.labelNameExcelStock.Location = new System.Drawing.Point(9, 141);
            this.labelNameExcelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameExcelStock.Name = "labelNameExcelStock";
            this.labelNameExcelStock.Size = new System.Drawing.Size(71, 13);
            this.labelNameExcelStock.TabIndex = 6;
            this.labelNameExcelStock.Text = "Excel (stock):";
            this.labelNameExcelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(45, 100);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "XML:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(462, 468);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listViewExcelStock
            // 
            this.listViewExcelStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewExcelStock.HideSelection = false;
            this.listViewExcelStock.Location = new System.Drawing.Point(94, 139);
            this.listViewExcelStock.Name = "listViewExcelStock";
            this.listViewExcelStock.Size = new System.Drawing.Size(302, 95);
            this.listViewExcelStock.TabIndex = 9;
            this.listViewExcelStock.UseCompatibleStateImageBehavior = false;
            this.listViewExcelStock.View = System.Windows.Forms.View.List;
            this.listViewExcelStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewExcelStock_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(542, 468);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // memoOutExcelStock
            // 
            this.memoOutExcelStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOutExcelStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoOutExcelStock.Location = new System.Drawing.Point(403, 139);
            this.memoOutExcelStock.Margin = new System.Windows.Forms.Padding(5);
            this.memoOutExcelStock.Name = "memoOutExcelStock";
            this.memoOutExcelStock.ReadOnly = true;
            this.memoOutExcelStock.Size = new System.Drawing.Size(214, 93);
            this.memoOutExcelStock.TabIndex = 10;
            this.memoOutExcelStock.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 507);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar.MaximumSize = new System.Drawing.Size(0, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(626, 30);
            this.progressBar.TabIndex = 11;
            this.progressBar.Tag = "";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(626, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnMenuFile
            // 
            this.btnMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuLogger});
            this.btnMenuFile.Name = "btnMenuFile";
            this.btnMenuFile.Size = new System.Drawing.Size(48, 20);
            this.btnMenuFile.Text = "Файл";
            // 
            // btnMenuLogger
            // 
            this.btnMenuLogger.Name = "btnMenuLogger";
            this.btnMenuLogger.Size = new System.Drawing.Size(123, 22);
            this.btnMenuLogger.Text = "События";
            this.btnMenuLogger.Click += new System.EventHandler(this.btnMenuLogger_Click);
            // 
            // checkIsInterop
            // 
            this.checkIsInterop.AutoSize = true;
            this.checkIsInterop.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIsInterop.Location = new System.Drawing.Point(0, 47);
            this.checkIsInterop.Margin = new System.Windows.Forms.Padding(5);
            this.checkIsInterop.Name = "checkIsInterop";
            this.checkIsInterop.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkIsInterop.Size = new System.Drawing.Size(626, 23);
            this.checkIsInterop.TabIndex = 13;
            this.checkIsInterop.Text = "Использовать Microsoft.Office.Interop.Excel";
            this.checkIsInterop.UseVisualStyleBackColor = true;
            this.checkIsInterop.CheckedChanged += new System.EventHandler(this.checkIsInterop_CheckedChanged);
            // 
            // checkIsEpplus
            // 
            this.checkIsEpplus.AutoSize = true;
            this.checkIsEpplus.Checked = true;
            this.checkIsEpplus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIsEpplus.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIsEpplus.Location = new System.Drawing.Point(0, 24);
            this.checkIsEpplus.Margin = new System.Windows.Forms.Padding(5);
            this.checkIsEpplus.Name = "checkIsEpplus";
            this.checkIsEpplus.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkIsEpplus.Size = new System.Drawing.Size(626, 23);
            this.checkIsEpplus.TabIndex = 14;
            this.checkIsEpplus.Text = "Использовать EPPlus";
            this.checkIsEpplus.UseVisualStyleBackColor = true;
            this.checkIsEpplus.CheckedChanged += new System.EventHandler(this.checkIsEpplus_CheckedChanged);
            // 
            // checkIsDeleteColumnNumber
            // 
            this.checkIsDeleteColumnNumber.AutoSize = true;
            this.checkIsDeleteColumnNumber.Checked = true;
            this.checkIsDeleteColumnNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIsDeleteColumnNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIsDeleteColumnNumber.Location = new System.Drawing.Point(0, 70);
            this.checkIsDeleteColumnNumber.Margin = new System.Windows.Forms.Padding(5);
            this.checkIsDeleteColumnNumber.Name = "checkIsDeleteColumnNumber";
            this.checkIsDeleteColumnNumber.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkIsDeleteColumnNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsDeleteColumnNumber.Size = new System.Drawing.Size(626, 23);
            this.checkIsDeleteColumnNumber.TabIndex = 15;
            this.checkIsDeleteColumnNumber.Text = "Удаление колонки с артикулом";
            this.checkIsDeleteColumnNumber.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(525, 27);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(91, 20);
            this.txtStock.TabIndex = 16;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(300, 30);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(222, 13);
            this.lblStock.TabIndex = 17;
            this.lblStock.Text = "Значение остатков (равное и меньше) в 0:";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtPricePerSet);
            this.panelControl.Controls.Add(this.checkPricePerSet);
            this.panelControl.Controls.Add(this.txtListNameStock);
            this.panelControl.Controls.Add(this.txtListNameO);
            this.panelControl.Controls.Add(this.txtListNameY);
            this.panelControl.Controls.Add(this.checkO);
            this.panelControl.Controls.Add(this.checkY);
            this.panelControl.Controls.Add(this.checkStock);
            this.panelControl.Controls.Add(this.txtPercentExcelO);
            this.panelControl.Controls.Add(this.txtAddNewPriceExcelO);
            this.panelControl.Controls.Add(this.txtAddCurrentPriceExcelO);
            this.panelControl.Controls.Add(this.txtCurrentPriceExcelO);
            this.panelControl.Controls.Add(this.txtArticuleExcelO);
            this.panelControl.Controls.Add(this.label1labelNameExcelO);
            this.panelControl.Controls.Add(this.memoOutExcelO);
            this.panelControl.Controls.Add(this.listViewExcelO);
            this.panelControl.Controls.Add(this.txtPercentExcelY);
            this.panelControl.Controls.Add(this.txtAddNewPriceExcelY);
            this.panelControl.Controls.Add(this.txtAddCurrentPriceExcelY);
            this.panelControl.Controls.Add(this.txtCurrentPriceExcelY);
            this.panelControl.Controls.Add(this.txtArticuleExcelY);
            this.panelControl.Controls.Add(this.labelNameExcelY);
            this.panelControl.Controls.Add(this.memoOutExcelY);
            this.panelControl.Controls.Add(this.listViewExcelY);
            this.panelControl.Controls.Add(this.lblPath);
            this.panelControl.Controls.Add(this.labelNameExcelStock);
            this.panelControl.Controls.Add(this.txtPath);
            this.panelControl.Controls.Add(this.btnStart);
            this.panelControl.Controls.Add(this.btnSelect);
            this.panelControl.Controls.Add(this.btnCancel);
            this.panelControl.Controls.Add(this.memoOutExcelStock);
            this.panelControl.Controls.Add(this.listViewExcelStock);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(626, 537);
            this.panelControl.TabIndex = 18;
            // 
            // txtPricePerSet
            // 
            this.txtPricePerSet.Location = new System.Drawing.Point(9, 197);
            this.txtPricePerSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtPricePerSet.Name = "txtPricePerSet";
            this.txtPricePerSet.Size = new System.Drawing.Size(80, 20);
            this.txtPricePerSet.TabIndex = 39;
            this.txtPricePerSet.Visible = false;
            // 
            // checkPricePerSet
            // 
            this.checkPricePerSet.AutoSize = true;
            this.checkPricePerSet.Location = new System.Drawing.Point(94, 239);
            this.checkPricePerSet.Margin = new System.Windows.Forms.Padding(2);
            this.checkPricePerSet.Name = "checkPricePerSet";
            this.checkPricePerSet.Size = new System.Drawing.Size(119, 17);
            this.checkPricePerSet.TabIndex = 38;
            this.checkPricePerSet.Text = "Цена за комплект";
            this.checkPricePerSet.UseVisualStyleBackColor = true;
            // 
            // txtListNameStock
            // 
            this.txtListNameStock.Location = new System.Drawing.Point(9, 156);
            this.txtListNameStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtListNameStock.Name = "txtListNameStock";
            this.txtListNameStock.Size = new System.Drawing.Size(80, 20);
            this.txtListNameStock.TabIndex = 37;
            this.txtListNameStock.Enter += new System.EventHandler(this.txtListName_Enter);
            // 
            // txtListNameO
            // 
            this.txtListNameO.Location = new System.Drawing.Point(9, 374);
            this.txtListNameO.Margin = new System.Windows.Forms.Padding(2);
            this.txtListNameO.Name = "txtListNameO";
            this.txtListNameO.Size = new System.Drawing.Size(80, 20);
            this.txtListNameO.TabIndex = 36;
            this.txtListNameO.Enter += new System.EventHandler(this.txtListName_Enter);
            // 
            // txtListNameY
            // 
            this.txtListNameY.Location = new System.Drawing.Point(9, 275);
            this.txtListNameY.Margin = new System.Windows.Forms.Padding(2);
            this.txtListNameY.Name = "txtListNameY";
            this.txtListNameY.Size = new System.Drawing.Size(80, 20);
            this.txtListNameY.TabIndex = 35;
            this.txtListNameY.Enter += new System.EventHandler(this.txtListName_Enter);
            // 
            // checkO
            // 
            this.checkO.AutoSize = true;
            this.checkO.Location = new System.Drawing.Point(75, 396);
            this.checkO.Margin = new System.Windows.Forms.Padding(2);
            this.checkO.Name = "checkO";
            this.checkO.Size = new System.Drawing.Size(15, 14);
            this.checkO.TabIndex = 34;
            this.checkO.UseVisualStyleBackColor = true;
            // 
            // checkY
            // 
            this.checkY.AutoSize = true;
            this.checkY.Location = new System.Drawing.Point(75, 298);
            this.checkY.Margin = new System.Windows.Forms.Padding(2);
            this.checkY.Name = "checkY";
            this.checkY.Size = new System.Drawing.Size(15, 14);
            this.checkY.TabIndex = 33;
            this.checkY.UseVisualStyleBackColor = true;
            // 
            // checkStock
            // 
            this.checkStock.AutoSize = true;
            this.checkStock.Location = new System.Drawing.Point(75, 179);
            this.checkStock.Margin = new System.Windows.Forms.Padding(2);
            this.checkStock.Name = "checkStock";
            this.checkStock.Size = new System.Drawing.Size(15, 14);
            this.checkStock.TabIndex = 32;
            this.checkStock.UseVisualStyleBackColor = true;
            this.checkStock.CheckedChanged += new System.EventHandler(this.checkStock_CheckedChanged);
            // 
            // txtPercentExcelO
            // 
            this.txtPercentExcelO.Location = new System.Drawing.Point(337, 431);
            this.txtPercentExcelO.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentExcelO.Name = "txtPercentExcelO";
            this.txtPercentExcelO.Size = new System.Drawing.Size(57, 20);
            this.txtPercentExcelO.TabIndex = 31;
            this.txtPercentExcelO.Text = "% (+/-)";
            this.txtPercentExcelO.Enter += new System.EventHandler(this.txtPercentExcel_Enter);
            // 
            // txtAddNewPriceExcelO
            // 
            this.txtAddNewPriceExcelO.Location = new System.Drawing.Point(276, 431);
            this.txtAddNewPriceExcelO.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddNewPriceExcelO.Name = "txtAddNewPriceExcelO";
            this.txtAddNewPriceExcelO.Size = new System.Drawing.Size(57, 20);
            this.txtAddNewPriceExcelO.TabIndex = 30;
            this.txtAddNewPriceExcelO.Text = "Ст.нов.цена";
            this.txtAddNewPriceExcelO.Enter += new System.EventHandler(this.txtAddNewPriceExcel_Enter);
            // 
            // txtAddCurrentPriceExcelO
            // 
            this.txtAddCurrentPriceExcelO.Location = new System.Drawing.Point(215, 431);
            this.txtAddCurrentPriceExcelO.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddCurrentPriceExcelO.Name = "txtAddCurrentPriceExcelO";
            this.txtAddCurrentPriceExcelO.Size = new System.Drawing.Size(57, 20);
            this.txtAddCurrentPriceExcelO.TabIndex = 29;
            this.txtAddCurrentPriceExcelO.Text = "Ст.тек.цена";
            this.txtAddCurrentPriceExcelO.Enter += new System.EventHandler(this.txtAddCurrentPriceExcel_Enter);
            // 
            // txtCurrentPriceExcelO
            // 
            this.txtCurrentPriceExcelO.Location = new System.Drawing.Point(154, 431);
            this.txtCurrentPriceExcelO.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentPriceExcelO.Name = "txtCurrentPriceExcelO";
            this.txtCurrentPriceExcelO.Size = new System.Drawing.Size(57, 20);
            this.txtCurrentPriceExcelO.TabIndex = 28;
            this.txtCurrentPriceExcelO.Text = "Тек.цена";
            this.txtCurrentPriceExcelO.Enter += new System.EventHandler(this.txtCurrentPriceExcel_Enter);
            // 
            // txtArticuleExcelO
            // 
            this.txtArticuleExcelO.Location = new System.Drawing.Point(94, 431);
            this.txtArticuleExcelO.Margin = new System.Windows.Forms.Padding(2);
            this.txtArticuleExcelO.Name = "txtArticuleExcelO";
            this.txtArticuleExcelO.Size = new System.Drawing.Size(57, 20);
            this.txtArticuleExcelO.TabIndex = 27;
            this.txtArticuleExcelO.Text = "Артикул";
            this.txtArticuleExcelO.Enter += new System.EventHandler(this.txtArticuleExcel_Enter);
            // 
            // label1labelNameExcelO
            // 
            this.label1labelNameExcelO.AutoSize = true;
            this.label1labelNameExcelO.Location = new System.Drawing.Point(9, 358);
            this.label1labelNameExcelO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1labelNameExcelO.Name = "label1labelNameExcelO";
            this.label1labelNameExcelO.Size = new System.Drawing.Size(80, 13);
            this.label1labelNameExcelO.TabIndex = 24;
            this.label1labelNameExcelO.Text = "Excel (Price O):";
            this.label1labelNameExcelO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoOutExcelO
            // 
            this.memoOutExcelO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOutExcelO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoOutExcelO.Location = new System.Drawing.Point(403, 357);
            this.memoOutExcelO.Margin = new System.Windows.Forms.Padding(5);
            this.memoOutExcelO.Name = "memoOutExcelO";
            this.memoOutExcelO.ReadOnly = true;
            this.memoOutExcelO.Size = new System.Drawing.Size(214, 93);
            this.memoOutExcelO.TabIndex = 26;
            this.memoOutExcelO.Text = "";
            // 
            // listViewExcelO
            // 
            this.listViewExcelO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewExcelO.HideSelection = false;
            this.listViewExcelO.Location = new System.Drawing.Point(94, 357);
            this.listViewExcelO.Name = "listViewExcelO";
            this.listViewExcelO.Size = new System.Drawing.Size(302, 70);
            this.listViewExcelO.TabIndex = 25;
            this.listViewExcelO.UseCompatibleStateImageBehavior = false;
            this.listViewExcelO.View = System.Windows.Forms.View.List;
            this.listViewExcelO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewExcelO_MouseUp);
            // 
            // txtPercentExcelY
            // 
            this.txtPercentExcelY.Location = new System.Drawing.Point(337, 333);
            this.txtPercentExcelY.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentExcelY.Name = "txtPercentExcelY";
            this.txtPercentExcelY.Size = new System.Drawing.Size(57, 20);
            this.txtPercentExcelY.TabIndex = 23;
            this.txtPercentExcelY.Text = "% (+/-)";
            this.txtPercentExcelY.Enter += new System.EventHandler(this.txtPercentExcel_Enter);
            // 
            // txtAddNewPriceExcelY
            // 
            this.txtAddNewPriceExcelY.Location = new System.Drawing.Point(276, 333);
            this.txtAddNewPriceExcelY.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddNewPriceExcelY.Name = "txtAddNewPriceExcelY";
            this.txtAddNewPriceExcelY.Size = new System.Drawing.Size(57, 20);
            this.txtAddNewPriceExcelY.TabIndex = 22;
            this.txtAddNewPriceExcelY.Text = "Ст.нов.цена";
            this.txtAddNewPriceExcelY.Enter += new System.EventHandler(this.txtAddNewPriceExcel_Enter);
            // 
            // txtAddCurrentPriceExcelY
            // 
            this.txtAddCurrentPriceExcelY.Location = new System.Drawing.Point(215, 333);
            this.txtAddCurrentPriceExcelY.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddCurrentPriceExcelY.Name = "txtAddCurrentPriceExcelY";
            this.txtAddCurrentPriceExcelY.Size = new System.Drawing.Size(57, 20);
            this.txtAddCurrentPriceExcelY.TabIndex = 21;
            this.txtAddCurrentPriceExcelY.Text = "Ст.тек.цена";
            this.txtAddCurrentPriceExcelY.Enter += new System.EventHandler(this.txtAddCurrentPriceExcel_Enter);
            // 
            // txtCurrentPriceExcelY
            // 
            this.txtCurrentPriceExcelY.Location = new System.Drawing.Point(154, 333);
            this.txtCurrentPriceExcelY.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentPriceExcelY.Name = "txtCurrentPriceExcelY";
            this.txtCurrentPriceExcelY.Size = new System.Drawing.Size(57, 20);
            this.txtCurrentPriceExcelY.TabIndex = 20;
            this.txtCurrentPriceExcelY.Text = "Тек.цена";
            this.txtCurrentPriceExcelY.Enter += new System.EventHandler(this.txtCurrentPriceExcel_Enter);
            // 
            // txtArticuleExcelY
            // 
            this.txtArticuleExcelY.Location = new System.Drawing.Point(94, 333);
            this.txtArticuleExcelY.Margin = new System.Windows.Forms.Padding(2);
            this.txtArticuleExcelY.Name = "txtArticuleExcelY";
            this.txtArticuleExcelY.Size = new System.Drawing.Size(57, 20);
            this.txtArticuleExcelY.TabIndex = 19;
            this.txtArticuleExcelY.Text = "Артикул";
            this.txtArticuleExcelY.Enter += new System.EventHandler(this.txtArticuleExcel_Enter);
            // 
            // labelNameExcelY
            // 
            this.labelNameExcelY.AutoSize = true;
            this.labelNameExcelY.Location = new System.Drawing.Point(9, 260);
            this.labelNameExcelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameExcelY.Name = "labelNameExcelY";
            this.labelNameExcelY.Size = new System.Drawing.Size(79, 13);
            this.labelNameExcelY.TabIndex = 11;
            this.labelNameExcelY.Text = "Excel (Price Y):";
            this.labelNameExcelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoOutExcelY
            // 
            this.memoOutExcelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOutExcelY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoOutExcelY.Location = new System.Drawing.Point(403, 258);
            this.memoOutExcelY.Margin = new System.Windows.Forms.Padding(5);
            this.memoOutExcelY.Name = "memoOutExcelY";
            this.memoOutExcelY.ReadOnly = true;
            this.memoOutExcelY.Size = new System.Drawing.Size(214, 93);
            this.memoOutExcelY.TabIndex = 13;
            this.memoOutExcelY.Text = "";
            // 
            // listViewExcelY
            // 
            this.listViewExcelY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewExcelY.HideSelection = false;
            this.listViewExcelY.Location = new System.Drawing.Point(94, 258);
            this.listViewExcelY.Name = "listViewExcelY";
            this.listViewExcelY.Size = new System.Drawing.Size(302, 70);
            this.listViewExcelY.TabIndex = 12;
            this.listViewExcelY.UseCompatibleStateImageBehavior = false;
            this.listViewExcelY.View = System.Windows.Forms.View.List;
            this.listViewExcelY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewExcelY_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 537);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.checkIsDeleteColumnNumber);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkIsInterop);
            this.Controls.Add(this.checkIsEpplus);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(642, 576);
            this.Name = "MainForm";
            this.Text = "XML TO EXCEL";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label labelNameExcelStock;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listViewExcelStock;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnMenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnMenuLogger;
        private System.Windows.Forms.CheckBox checkIsInterop;
        private System.Windows.Forms.CheckBox checkIsEpplus;
        private System.Windows.Forms.CheckBox checkIsDeleteColumnNumber;
        private System.Windows.Forms.RichTextBox memoOutExcelStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label labelNameExcelY;
        private System.Windows.Forms.RichTextBox memoOutExcelY;
        private System.Windows.Forms.ListView listViewExcelY;
        private System.Windows.Forms.TextBox txtPercentExcelY;
        private System.Windows.Forms.TextBox txtAddNewPriceExcelY;
        private System.Windows.Forms.TextBox txtAddCurrentPriceExcelY;
        private System.Windows.Forms.TextBox txtCurrentPriceExcelY;
        private System.Windows.Forms.TextBox txtArticuleExcelY;
        private System.Windows.Forms.TextBox txtPercentExcelO;
        private System.Windows.Forms.TextBox txtAddNewPriceExcelO;
        private System.Windows.Forms.TextBox txtAddCurrentPriceExcelO;
        private System.Windows.Forms.TextBox txtCurrentPriceExcelO;
        private System.Windows.Forms.TextBox txtArticuleExcelO;
        private System.Windows.Forms.Label label1labelNameExcelO;
        private System.Windows.Forms.RichTextBox memoOutExcelO;
        private System.Windows.Forms.ListView listViewExcelO;
        private System.Windows.Forms.CheckBox checkO;
        private System.Windows.Forms.CheckBox checkY;
        private System.Windows.Forms.CheckBox checkStock;
        private System.Windows.Forms.TextBox txtListNameStock;
        private System.Windows.Forms.TextBox txtListNameO;
        private System.Windows.Forms.TextBox txtListNameY;
        private System.Windows.Forms.CheckBox checkPricePerSet;
        private System.Windows.Forms.TextBox txtPricePerSet;
    }
}

