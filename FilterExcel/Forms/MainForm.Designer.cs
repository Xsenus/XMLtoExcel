namespace FilterExcel.Forms
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
            this.btnOpenExcel = new System.Windows.Forms.Button();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.lblExcel = new System.Windows.Forms.Label();
            this.txtCol1 = new System.Windows.Forms.TextBox();
            this.lblCol1 = new System.Windows.Forms.Label();
            this.btnFillValue = new System.Windows.Forms.Button();
            this.lblCol2 = new System.Windows.Forms.Label();
            this.txtCol2 = new System.Windows.Forms.TextBox();
            this.lblCol3 = new System.Windows.Forms.Label();
            this.txtCol3 = new System.Windows.Forms.TextBox();
            this.lblCol4 = new System.Windows.Forms.Label();
            this.txtCol4 = new System.Windows.Forms.TextBox();
            this.lblCol5 = new System.Windows.Forms.Label();
            this.txtCol5 = new System.Windows.Forms.TextBox();
            this.lblCol6 = new System.Windows.Forms.Label();
            this.txtCol6 = new System.Windows.Forms.TextBox();
            this.lblCol7 = new System.Windows.Forms.Label();
            this.txtCol7 = new System.Windows.Forms.TextBox();
            this.cmbCol1 = new System.Windows.Forms.ComboBox();
            this.cmbCol2 = new System.Windows.Forms.ComboBox();
            this.cmbCol3 = new System.Windows.Forms.ComboBox();
            this.cmbCol4 = new System.Windows.Forms.ComboBox();
            this.cmbCol5 = new System.Windows.Forms.ComboBox();
            this.cmbCol6 = new System.Windows.Forms.ComboBox();
            this.cmbCol7 = new System.Windows.Forms.ComboBox();
            this.txtExcelWorksheet = new System.Windows.Forms.TextBox();
            this.lblExcelWorksheet = new System.Windows.Forms.Label();
            this.lblRowPosition = new System.Windows.Forms.Label();
            this.txtRowPosition = new System.Windows.Forms.TextBox();
            this.lblVendorCodeColumn = new System.Windows.Forms.Label();
            this.txtVendorCodeColumn = new System.Windows.Forms.TextBox();
            this.lblNewColumnValue = new System.Windows.Forms.Label();
            this.txtNewColumnValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnWorkOutExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenExcel
            // 
            this.btnOpenExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenExcel.Location = new System.Drawing.Point(640, 12);
            this.btnOpenExcel.Name = "btnOpenExcel";
            this.btnOpenExcel.Size = new System.Drawing.Size(30, 30);
            this.btnOpenExcel.TabIndex = 0;
            this.btnOpenExcel.Text = "+";
            this.btnOpenExcel.UseVisualStyleBackColor = true;
            this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
            // 
            // txtExcel
            // 
            this.txtExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcel.Location = new System.Drawing.Point(98, 13);
            this.txtExcel.Multiline = true;
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(526, 30);
            this.txtExcel.TabIndex = 1;
            this.txtExcel.DoubleClick += new System.EventHandler(this.txtExcel_DoubleClick);
            // 
            // lblExcel
            // 
            this.lblExcel.AutoSize = true;
            this.lblExcel.Location = new System.Drawing.Point(34, 19);
            this.lblExcel.Name = "lblExcel";
            this.lblExcel.Size = new System.Drawing.Size(40, 16);
            this.lblExcel.TabIndex = 2;
            this.lblExcel.Text = "Excel";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(98, 156);
            this.txtCol1.Multiline = true;
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(100, 24);
            this.txtCol1.TabIndex = 3;
            // 
            // lblCol1
            // 
            this.lblCol1.AutoSize = true;
            this.lblCol1.Location = new System.Drawing.Point(12, 159);
            this.lblCol1.Name = "lblCol1";
            this.lblCol1.Size = new System.Drawing.Size(62, 16);
            this.lblCol1.TabIndex = 4;
            this.lblCol1.Text = "Column 1";
            // 
            // btnFillValue
            // 
            this.btnFillValue.Location = new System.Drawing.Point(204, 156);
            this.btnFillValue.Name = "btnFillValue";
            this.btnFillValue.Size = new System.Drawing.Size(134, 204);
            this.btnFillValue.TabIndex = 5;
            this.btnFillValue.Text = "Заполнить значениями";
            this.btnFillValue.UseVisualStyleBackColor = true;
            this.btnFillValue.Click += new System.EventHandler(this.btnFillValue_Click);
            // 
            // lblCol2
            // 
            this.lblCol2.AutoSize = true;
            this.lblCol2.Location = new System.Drawing.Point(12, 189);
            this.lblCol2.Name = "lblCol2";
            this.lblCol2.Size = new System.Drawing.Size(62, 16);
            this.lblCol2.TabIndex = 7;
            this.lblCol2.Text = "Column 2";
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(98, 186);
            this.txtCol2.Multiline = true;
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(100, 24);
            this.txtCol2.TabIndex = 6;
            // 
            // lblCol3
            // 
            this.lblCol3.AutoSize = true;
            this.lblCol3.Location = new System.Drawing.Point(12, 219);
            this.lblCol3.Name = "lblCol3";
            this.lblCol3.Size = new System.Drawing.Size(62, 16);
            this.lblCol3.TabIndex = 9;
            this.lblCol3.Text = "Column 3";
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(98, 216);
            this.txtCol3.Multiline = true;
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(100, 24);
            this.txtCol3.TabIndex = 8;
            // 
            // lblCol4
            // 
            this.lblCol4.AutoSize = true;
            this.lblCol4.Location = new System.Drawing.Point(12, 250);
            this.lblCol4.Name = "lblCol4";
            this.lblCol4.Size = new System.Drawing.Size(62, 16);
            this.lblCol4.TabIndex = 11;
            this.lblCol4.Text = "Column 4";
            // 
            // txtCol4
            // 
            this.txtCol4.Location = new System.Drawing.Point(98, 246);
            this.txtCol4.Multiline = true;
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(100, 24);
            this.txtCol4.TabIndex = 10;
            // 
            // lblCol5
            // 
            this.lblCol5.AutoSize = true;
            this.lblCol5.Location = new System.Drawing.Point(12, 279);
            this.lblCol5.Name = "lblCol5";
            this.lblCol5.Size = new System.Drawing.Size(62, 16);
            this.lblCol5.TabIndex = 13;
            this.lblCol5.Text = "Column 5";
            // 
            // txtCol5
            // 
            this.txtCol5.Location = new System.Drawing.Point(98, 276);
            this.txtCol5.Multiline = true;
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(100, 24);
            this.txtCol5.TabIndex = 12;
            // 
            // lblCol6
            // 
            this.lblCol6.AutoSize = true;
            this.lblCol6.Location = new System.Drawing.Point(12, 309);
            this.lblCol6.Name = "lblCol6";
            this.lblCol6.Size = new System.Drawing.Size(62, 16);
            this.lblCol6.TabIndex = 15;
            this.lblCol6.Text = "Column 6";
            // 
            // txtCol6
            // 
            this.txtCol6.Location = new System.Drawing.Point(98, 306);
            this.txtCol6.Multiline = true;
            this.txtCol6.Name = "txtCol6";
            this.txtCol6.Size = new System.Drawing.Size(100, 24);
            this.txtCol6.TabIndex = 14;
            // 
            // lblCol7
            // 
            this.lblCol7.AutoSize = true;
            this.lblCol7.Location = new System.Drawing.Point(12, 339);
            this.lblCol7.Name = "lblCol7";
            this.lblCol7.Size = new System.Drawing.Size(62, 16);
            this.lblCol7.TabIndex = 17;
            this.lblCol7.Text = "Column 7";
            // 
            // txtCol7
            // 
            this.txtCol7.Location = new System.Drawing.Point(98, 336);
            this.txtCol7.Multiline = true;
            this.txtCol7.Name = "txtCol7";
            this.txtCol7.Size = new System.Drawing.Size(100, 24);
            this.txtCol7.TabIndex = 16;
            // 
            // cmbCol1
            // 
            this.cmbCol1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol1.ItemHeight = 16;
            this.cmbCol1.Location = new System.Drawing.Point(358, 157);
            this.cmbCol1.MaxDropDownItems = 15;
            this.cmbCol1.Name = "cmbCol1";
            this.cmbCol1.Size = new System.Drawing.Size(266, 24);
            this.cmbCol1.TabIndex = 18;
            // 
            // cmbCol2
            // 
            this.cmbCol2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol2.ItemHeight = 16;
            this.cmbCol2.Location = new System.Drawing.Point(358, 187);
            this.cmbCol2.MaxDropDownItems = 15;
            this.cmbCol2.Name = "cmbCol2";
            this.cmbCol2.Size = new System.Drawing.Size(266, 24);
            this.cmbCol2.TabIndex = 19;
            // 
            // cmbCol3
            // 
            this.cmbCol3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol3.ItemHeight = 16;
            this.cmbCol3.Location = new System.Drawing.Point(358, 217);
            this.cmbCol3.MaxDropDownItems = 15;
            this.cmbCol3.Name = "cmbCol3";
            this.cmbCol3.Size = new System.Drawing.Size(266, 24);
            this.cmbCol3.TabIndex = 20;
            // 
            // cmbCol4
            // 
            this.cmbCol4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol4.ItemHeight = 16;
            this.cmbCol4.Location = new System.Drawing.Point(358, 247);
            this.cmbCol4.MaxDropDownItems = 15;
            this.cmbCol4.Name = "cmbCol4";
            this.cmbCol4.Size = new System.Drawing.Size(266, 24);
            this.cmbCol4.TabIndex = 21;
            // 
            // cmbCol5
            // 
            this.cmbCol5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol5.ItemHeight = 16;
            this.cmbCol5.Location = new System.Drawing.Point(358, 277);
            this.cmbCol5.MaxDropDownItems = 15;
            this.cmbCol5.Name = "cmbCol5";
            this.cmbCol5.Size = new System.Drawing.Size(266, 24);
            this.cmbCol5.TabIndex = 22;
            // 
            // cmbCol6
            // 
            this.cmbCol6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol6.ItemHeight = 16;
            this.cmbCol6.Location = new System.Drawing.Point(358, 307);
            this.cmbCol6.MaxDropDownItems = 15;
            this.cmbCol6.Name = "cmbCol6";
            this.cmbCol6.Size = new System.Drawing.Size(266, 24);
            this.cmbCol6.TabIndex = 23;
            // 
            // cmbCol7
            // 
            this.cmbCol7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCol7.ItemHeight = 16;
            this.cmbCol7.Location = new System.Drawing.Point(358, 337);
            this.cmbCol7.MaxDropDownItems = 15;
            this.cmbCol7.Name = "cmbCol7";
            this.cmbCol7.Size = new System.Drawing.Size(266, 24);
            this.cmbCol7.TabIndex = 24;
            // 
            // txtExcelWorksheet
            // 
            this.txtExcelWorksheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcelWorksheet.Location = new System.Drawing.Point(358, 49);
            this.txtExcelWorksheet.Multiline = true;
            this.txtExcelWorksheet.Name = "txtExcelWorksheet";
            this.txtExcelWorksheet.Size = new System.Drawing.Size(266, 30);
            this.txtExcelWorksheet.TabIndex = 25;
            this.txtExcelWorksheet.Text = "Лист 1";
            // 
            // lblExcelWorksheet
            // 
            this.lblExcelWorksheet.AutoSize = true;
            this.lblExcelWorksheet.Location = new System.Drawing.Point(95, 59);
            this.lblExcelWorksheet.Name = "lblExcelWorksheet";
            this.lblExcelWorksheet.Size = new System.Drawing.Size(243, 16);
            this.lblExcelWorksheet.TabIndex = 26;
            this.lblExcelWorksheet.Text = "Наименование страницы или номер";
            // 
            // lblRowPosition
            // 
            this.lblRowPosition.AutoSize = true;
            this.lblRowPosition.Location = new System.Drawing.Point(189, 92);
            this.lblRowPosition.Name = "lblRowPosition";
            this.lblRowPosition.Size = new System.Drawing.Size(149, 16);
            this.lblRowPosition.TabIndex = 28;
            this.lblRowPosition.Text = "Номер первой строки";
            // 
            // txtRowPosition
            // 
            this.txtRowPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRowPosition.Location = new System.Drawing.Point(358, 85);
            this.txtRowPosition.Multiline = true;
            this.txtRowPosition.Name = "txtRowPosition";
            this.txtRowPosition.Size = new System.Drawing.Size(266, 30);
            this.txtRowPosition.TabIndex = 27;
            this.txtRowPosition.Text = "2";
            // 
            // lblVendorCodeColumn
            // 
            this.lblVendorCodeColumn.AutoSize = true;
            this.lblVendorCodeColumn.Location = new System.Drawing.Point(191, 410);
            this.lblVendorCodeColumn.Name = "lblVendorCodeColumn";
            this.lblVendorCodeColumn.Size = new System.Drawing.Size(147, 16);
            this.lblVendorCodeColumn.TabIndex = 32;
            this.lblVendorCodeColumn.Text = "Столбец с артикулом";
            // 
            // txtVendorCodeColumn
            // 
            this.txtVendorCodeColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorCodeColumn.Location = new System.Drawing.Point(358, 403);
            this.txtVendorCodeColumn.Multiline = true;
            this.txtVendorCodeColumn.Name = "txtVendorCodeColumn";
            this.txtVendorCodeColumn.Size = new System.Drawing.Size(266, 30);
            this.txtVendorCodeColumn.TabIndex = 31;
            // 
            // lblNewColumnValue
            // 
            this.lblNewColumnValue.AutoSize = true;
            this.lblNewColumnValue.Location = new System.Drawing.Point(13, 446);
            this.lblNewColumnValue.Name = "lblNewColumnValue";
            this.lblNewColumnValue.Size = new System.Drawing.Size(325, 16);
            this.lblNewColumnValue.TabIndex = 34;
            this.lblNewColumnValue.Text = "Столбец, в который будет устаовлено значение";
            // 
            // txtNewColumnValue
            // 
            this.txtNewColumnValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewColumnValue.Location = new System.Drawing.Point(358, 439);
            this.txtNewColumnValue.Multiline = true;
            this.txtNewColumnValue.Name = "txtNewColumnValue";
            this.txtNewColumnValue.Size = new System.Drawing.Size(266, 30);
            this.txtNewColumnValue.TabIndex = 33;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(199, 482);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(139, 16);
            this.lblValue.TabIndex = 36;
            this.lblValue.Text = "Символ добавления";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(358, 475);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(266, 30);
            this.txtValue.TabIndex = 35;
            // 
            // btnWorkOutExcel
            // 
            this.btnWorkOutExcel.Location = new System.Drawing.Point(358, 511);
            this.btnWorkOutExcel.Name = "btnWorkOutExcel";
            this.btnWorkOutExcel.Size = new System.Drawing.Size(266, 50);
            this.btnWorkOutExcel.TabIndex = 37;
            this.btnWorkOutExcel.Text = "Отработать Excel";
            this.btnWorkOutExcel.UseVisualStyleBackColor = true;
            this.btnWorkOutExcel.Click += new System.EventHandler(this.btnWorkOutExcel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 596);
            this.Controls.Add(this.btnWorkOutExcel);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblNewColumnValue);
            this.Controls.Add(this.txtNewColumnValue);
            this.Controls.Add(this.lblVendorCodeColumn);
            this.Controls.Add(this.txtVendorCodeColumn);
            this.Controls.Add(this.lblRowPosition);
            this.Controls.Add(this.txtRowPosition);
            this.Controls.Add(this.lblExcelWorksheet);
            this.Controls.Add(this.txtExcelWorksheet);
            this.Controls.Add(this.cmbCol7);
            this.Controls.Add(this.cmbCol6);
            this.Controls.Add(this.cmbCol5);
            this.Controls.Add(this.cmbCol4);
            this.Controls.Add(this.cmbCol3);
            this.Controls.Add(this.cmbCol2);
            this.Controls.Add(this.cmbCol1);
            this.Controls.Add(this.lblCol7);
            this.Controls.Add(this.txtCol7);
            this.Controls.Add(this.lblCol6);
            this.Controls.Add(this.txtCol6);
            this.Controls.Add(this.lblCol5);
            this.Controls.Add(this.txtCol5);
            this.Controls.Add(this.lblCol4);
            this.Controls.Add(this.txtCol4);
            this.Controls.Add(this.lblCol3);
            this.Controls.Add(this.txtCol3);
            this.Controls.Add(this.lblCol2);
            this.Controls.Add(this.txtCol2);
            this.Controls.Add(this.btnFillValue);
            this.Controls.Add(this.lblCol1);
            this.Controls.Add(this.txtCol1);
            this.Controls.Add(this.lblExcel);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.btnOpenExcel);
            this.Name = "MainForm";
            this.Text = "Фильтрация Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenExcel;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Label lblExcel;
        private System.Windows.Forms.TextBox txtCol1;
        private System.Windows.Forms.Label lblCol1;
        private System.Windows.Forms.Button btnFillValue;
        private System.Windows.Forms.Label lblCol2;
        private System.Windows.Forms.TextBox txtCol2;
        private System.Windows.Forms.Label lblCol3;
        private System.Windows.Forms.TextBox txtCol3;
        private System.Windows.Forms.Label lblCol4;
        private System.Windows.Forms.TextBox txtCol4;
        private System.Windows.Forms.Label lblCol5;
        private System.Windows.Forms.TextBox txtCol5;
        private System.Windows.Forms.Label lblCol6;
        private System.Windows.Forms.TextBox txtCol6;
        private System.Windows.Forms.Label lblCol7;
        private System.Windows.Forms.TextBox txtCol7;
        private System.Windows.Forms.ComboBox cmbCol1;
        private System.Windows.Forms.ComboBox cmbCol2;
        private System.Windows.Forms.ComboBox cmbCol3;
        private System.Windows.Forms.ComboBox cmbCol4;
        private System.Windows.Forms.ComboBox cmbCol5;
        private System.Windows.Forms.ComboBox cmbCol6;
        private System.Windows.Forms.ComboBox cmbCol7;
        private System.Windows.Forms.TextBox txtExcelWorksheet;
        private System.Windows.Forms.Label lblExcelWorksheet;
        private System.Windows.Forms.Label lblRowPosition;
        private System.Windows.Forms.TextBox txtRowPosition;
        private System.Windows.Forms.Label lblVendorCodeColumn;
        private System.Windows.Forms.TextBox txtVendorCodeColumn;
        private System.Windows.Forms.Label lblNewColumnValue;
        private System.Windows.Forms.TextBox txtNewColumnValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnWorkOutExcel;
    }
}

