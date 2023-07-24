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
            this.txtPath.Location = new System.Drawing.Point(125, 120);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.MinimumSize = new System.Drawing.Size(399, 4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(644, 45);
            this.txtPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(775, 120);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(45, 45);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "+";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // labelNameExcelStock
            // 
            this.labelNameExcelStock.AutoSize = true;
            this.labelNameExcelStock.Location = new System.Drawing.Point(12, 175);
            this.labelNameExcelStock.Name = "labelNameExcelStock";
            this.labelNameExcelStock.Size = new System.Drawing.Size(86, 16);
            this.labelNameExcelStock.TabIndex = 6;
            this.labelNameExcelStock.Text = "Excel (stock):";
            this.labelNameExcelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(60, 123);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(36, 16);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "XML:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(614, 543);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 40);
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
            this.listViewExcelStock.Location = new System.Drawing.Point(125, 173);
            this.listViewExcelStock.Margin = new System.Windows.Forms.Padding(4);
            this.listViewExcelStock.Name = "listViewExcelStock";
            this.listViewExcelStock.Size = new System.Drawing.Size(399, 116);
            this.listViewExcelStock.TabIndex = 9;
            this.listViewExcelStock.UseCompatibleStateImageBehavior = false;
            this.listViewExcelStock.View = System.Windows.Forms.View.List;
            this.listViewExcelStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewExcelStock_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(720, 543);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // memoOutExcelStock
            // 
            this.memoOutExcelStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOutExcelStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoOutExcelStock.Location = new System.Drawing.Point(535, 173);
            this.memoOutExcelStock.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.memoOutExcelStock.Name = "memoOutExcelStock";
            this.memoOutExcelStock.ReadOnly = true;
            this.memoOutExcelStock.Size = new System.Drawing.Size(285, 114);
            this.memoOutExcelStock.TabIndex = 10;
            this.memoOutExcelStock.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 591);
            this.progressBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.progressBar.MaximumSize = new System.Drawing.Size(0, 37);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(832, 37);
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(832, 28);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnMenuFile
            // 
            this.btnMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuLogger});
            this.btnMenuFile.Name = "btnMenuFile";
            this.btnMenuFile.Size = new System.Drawing.Size(59, 24);
            this.btnMenuFile.Text = "Файл";
            // 
            // btnMenuLogger
            // 
            this.btnMenuLogger.Name = "btnMenuLogger";
            this.btnMenuLogger.Size = new System.Drawing.Size(153, 26);
            this.btnMenuLogger.Text = "События";
            this.btnMenuLogger.Click += new System.EventHandler(this.btnMenuLogger_Click);
            // 
            // checkIsInterop
            // 
            this.checkIsInterop.AutoSize = true;
            this.checkIsInterop.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIsInterop.Location = new System.Drawing.Point(0, 56);
            this.checkIsInterop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.checkIsInterop.Name = "checkIsInterop";
            this.checkIsInterop.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.checkIsInterop.Size = new System.Drawing.Size(832, 28);
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
            this.checkIsEpplus.Location = new System.Drawing.Point(0, 28);
            this.checkIsEpplus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.checkIsEpplus.Name = "checkIsEpplus";
            this.checkIsEpplus.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.checkIsEpplus.Size = new System.Drawing.Size(832, 28);
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
            this.checkIsDeleteColumnNumber.Location = new System.Drawing.Point(0, 84);
            this.checkIsDeleteColumnNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.checkIsDeleteColumnNumber.Name = "checkIsDeleteColumnNumber";
            this.checkIsDeleteColumnNumber.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.checkIsDeleteColumnNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsDeleteColumnNumber.Size = new System.Drawing.Size(832, 28);
            this.checkIsDeleteColumnNumber.TabIndex = 15;
            this.checkIsDeleteColumnNumber.Text = "Удаление колонки с артикулом";
            this.checkIsDeleteColumnNumber.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(700, 33);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 22);
            this.txtStock.TabIndex = 16;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(400, 37);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(281, 16);
            this.lblStock.TabIndex = 17;
            this.lblStock.Text = "Значение остатков (равное и меньше) в 0:";
            // 
            // panelControl
            // 
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
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(832, 628);
            this.panelControl.TabIndex = 18;
            // 
            // txtPercentExcelO
            // 
            this.txtPercentExcelO.Location = new System.Drawing.Point(449, 512);
            this.txtPercentExcelO.Name = "txtPercentExcelO";
            this.txtPercentExcelO.Size = new System.Drawing.Size(75, 22);
            this.txtPercentExcelO.TabIndex = 31;
            this.txtPercentExcelO.Text = "% (+/-)";
            this.txtPercentExcelO.Enter += new System.EventHandler(this.txtPercentExcel_Enter);
            // 
            // txtAddNewPriceExcelO
            // 
            this.txtAddNewPriceExcelO.Location = new System.Drawing.Point(368, 512);
            this.txtAddNewPriceExcelO.Name = "txtAddNewPriceExcelO";
            this.txtAddNewPriceExcelO.Size = new System.Drawing.Size(75, 22);
            this.txtAddNewPriceExcelO.TabIndex = 30;
            this.txtAddNewPriceExcelO.Text = "Ст.нов.цена";
            this.txtAddNewPriceExcelO.Enter += new System.EventHandler(this.txtAddNewPriceExcel_Enter);
            // 
            // txtAddCurrentPriceExcelO
            // 
            this.txtAddCurrentPriceExcelO.Location = new System.Drawing.Point(287, 512);
            this.txtAddCurrentPriceExcelO.Name = "txtAddCurrentPriceExcelO";
            this.txtAddCurrentPriceExcelO.Size = new System.Drawing.Size(75, 22);
            this.txtAddCurrentPriceExcelO.TabIndex = 29;
            this.txtAddCurrentPriceExcelO.Text = "Ст.тек.цена";
            this.txtAddCurrentPriceExcelO.Enter += new System.EventHandler(this.txtAddCurrentPriceExcel_Enter);
            // 
            // txtCurrentPriceExcelO
            // 
            this.txtCurrentPriceExcelO.Location = new System.Drawing.Point(206, 512);
            this.txtCurrentPriceExcelO.Name = "txtCurrentPriceExcelO";
            this.txtCurrentPriceExcelO.Size = new System.Drawing.Size(75, 22);
            this.txtCurrentPriceExcelO.TabIndex = 28;
            this.txtCurrentPriceExcelO.Text = "Тек.цена";
            this.txtCurrentPriceExcelO.Enter += new System.EventHandler(this.txtCurrentPriceExcel_Enter);
            // 
            // txtArticuleExcelO
            // 
            this.txtArticuleExcelO.Location = new System.Drawing.Point(125, 512);
            this.txtArticuleExcelO.Name = "txtArticuleExcelO";
            this.txtArticuleExcelO.Size = new System.Drawing.Size(75, 22);
            this.txtArticuleExcelO.TabIndex = 27;
            this.txtArticuleExcelO.Text = "Артикул";
            this.txtArticuleExcelO.Enter += new System.EventHandler(this.txtArticuleExcel_Enter);
            // 
            // label1labelNameExcelO
            // 
            this.label1labelNameExcelO.AutoSize = true;
            this.label1labelNameExcelO.Location = new System.Drawing.Point(12, 422);
            this.label1labelNameExcelO.Name = "label1labelNameExcelO";
            this.label1labelNameExcelO.Size = new System.Drawing.Size(98, 16);
            this.label1labelNameExcelO.TabIndex = 24;
            this.label1labelNameExcelO.Text = "Excel (Price O):";
            this.label1labelNameExcelO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoOutExcelO
            // 
            this.memoOutExcelO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOutExcelO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoOutExcelO.Location = new System.Drawing.Point(535, 420);
            this.memoOutExcelO.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.memoOutExcelO.Name = "memoOutExcelO";
            this.memoOutExcelO.ReadOnly = true;
            this.memoOutExcelO.Size = new System.Drawing.Size(285, 114);
            this.memoOutExcelO.TabIndex = 26;
            this.memoOutExcelO.Text = "";
            // 
            // listViewExcelO
            // 
            this.listViewExcelO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewExcelO.HideSelection = false;
            this.listViewExcelO.Location = new System.Drawing.Point(125, 420);
            this.listViewExcelO.Margin = new System.Windows.Forms.Padding(4);
            this.listViewExcelO.Name = "listViewExcelO";
            this.listViewExcelO.Size = new System.Drawing.Size(399, 85);
            this.listViewExcelO.TabIndex = 25;
            this.listViewExcelO.UseCompatibleStateImageBehavior = false;
            this.listViewExcelO.View = System.Windows.Forms.View.List;
            this.listViewExcelO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewExcelO_MouseUp);
            // 
            // txtPercentExcelY
            // 
            this.txtPercentExcelY.Location = new System.Drawing.Point(449, 391);
            this.txtPercentExcelY.Name = "txtPercentExcelY";
            this.txtPercentExcelY.Size = new System.Drawing.Size(75, 22);
            this.txtPercentExcelY.TabIndex = 23;
            this.txtPercentExcelY.Text = "% (+/-)";
            this.txtPercentExcelY.Enter += new System.EventHandler(this.txtPercentExcel_Enter);
            // 
            // txtAddNewPriceExcelY
            // 
            this.txtAddNewPriceExcelY.Location = new System.Drawing.Point(368, 391);
            this.txtAddNewPriceExcelY.Name = "txtAddNewPriceExcelY";
            this.txtAddNewPriceExcelY.Size = new System.Drawing.Size(75, 22);
            this.txtAddNewPriceExcelY.TabIndex = 22;
            this.txtAddNewPriceExcelY.Text = "Ст.нов.цена";
            this.txtAddNewPriceExcelY.Enter += new System.EventHandler(this.txtAddNewPriceExcel_Enter);
            // 
            // txtAddCurrentPriceExcelY
            // 
            this.txtAddCurrentPriceExcelY.Location = new System.Drawing.Point(287, 391);
            this.txtAddCurrentPriceExcelY.Name = "txtAddCurrentPriceExcelY";
            this.txtAddCurrentPriceExcelY.Size = new System.Drawing.Size(75, 22);
            this.txtAddCurrentPriceExcelY.TabIndex = 21;
            this.txtAddCurrentPriceExcelY.Text = "Ст.тек.цена";
            this.txtAddCurrentPriceExcelY.Enter += new System.EventHandler(this.txtAddCurrentPriceExcel_Enter);
            // 
            // txtCurrentPriceExcelY
            // 
            this.txtCurrentPriceExcelY.Location = new System.Drawing.Point(206, 391);
            this.txtCurrentPriceExcelY.Name = "txtCurrentPriceExcelY";
            this.txtCurrentPriceExcelY.Size = new System.Drawing.Size(75, 22);
            this.txtCurrentPriceExcelY.TabIndex = 20;
            this.txtCurrentPriceExcelY.Text = "Тек.цена";
            this.txtCurrentPriceExcelY.Enter += new System.EventHandler(this.txtCurrentPriceExcel_Enter);
            // 
            // txtArticuleExcelY
            // 
            this.txtArticuleExcelY.Location = new System.Drawing.Point(125, 391);
            this.txtArticuleExcelY.Name = "txtArticuleExcelY";
            this.txtArticuleExcelY.Size = new System.Drawing.Size(75, 22);
            this.txtArticuleExcelY.TabIndex = 19;
            this.txtArticuleExcelY.Text = "Артикул";
            this.txtArticuleExcelY.Enter += new System.EventHandler(this.txtArticuleExcel_Enter);
            // 
            // labelNameExcelY
            // 
            this.labelNameExcelY.AutoSize = true;
            this.labelNameExcelY.Location = new System.Drawing.Point(12, 301);
            this.labelNameExcelY.Name = "labelNameExcelY";
            this.labelNameExcelY.Size = new System.Drawing.Size(97, 16);
            this.labelNameExcelY.TabIndex = 11;
            this.labelNameExcelY.Text = "Excel (Price Y):";
            this.labelNameExcelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoOutExcelY
            // 
            this.memoOutExcelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOutExcelY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoOutExcelY.Location = new System.Drawing.Point(535, 299);
            this.memoOutExcelY.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.memoOutExcelY.Name = "memoOutExcelY";
            this.memoOutExcelY.ReadOnly = true;
            this.memoOutExcelY.Size = new System.Drawing.Size(285, 114);
            this.memoOutExcelY.TabIndex = 13;
            this.memoOutExcelY.Text = "";
            // 
            // listViewExcelY
            // 
            this.listViewExcelY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewExcelY.HideSelection = false;
            this.listViewExcelY.Location = new System.Drawing.Point(125, 299);
            this.listViewExcelY.Margin = new System.Windows.Forms.Padding(4);
            this.listViewExcelY.Name = "listViewExcelY";
            this.listViewExcelY.Size = new System.Drawing.Size(399, 85);
            this.listViewExcelY.TabIndex = 12;
            this.listViewExcelY.UseCompatibleStateImageBehavior = false;
            this.listViewExcelY.View = System.Windows.Forms.View.List;
            this.listViewExcelY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewExcelY_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 628);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(850, 675);
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
    }
}

