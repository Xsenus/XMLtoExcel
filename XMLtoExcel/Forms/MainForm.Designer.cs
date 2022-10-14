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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.btnAddExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuLogger = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIsInterop = new System.Windows.Forms.CheckBox();
            this.checkIsEpplus = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.Location = new System.Drawing.Point(137, 8);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.MinimumSize = new System.Drawing.Size(399, 4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(546, 66);
            this.txtPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Location = new System.Drawing.Point(693, 12);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(199, 58);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "+";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblPath, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtPath, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.btnStart, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.listView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btnSelect, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.btnAddExcel, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.btnCancel, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.lblCount, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(906, 293);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(10, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 140);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Excel:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(10, 6);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(121, 70);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "XML:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(137, 218);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(546, 67);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(138, 80);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(544, 132);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // btnAddExcel
            // 
            this.btnAddExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddExcel.Location = new System.Drawing.Point(693, 82);
            this.btnAddExcel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddExcel.Name = "btnAddExcel";
            this.btnAddExcel.Size = new System.Drawing.Size(199, 128);
            this.btnAddExcel.TabIndex = 10;
            this.btnAddExcel.Text = "+";
            this.btnAddExcel.UseVisualStyleBackColor = true;
            this.btnAddExcel.Click += new System.EventHandler(this.btnAddExcel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(689, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 67);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Location = new System.Drawing.Point(10, 216);
            this.lblCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(121, 71);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Замены: 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 365);
            this.progressBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.progressBar.MaximumSize = new System.Drawing.Size(0, 37);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(906, 37);
            this.progressBar.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuFile
            // 
            this.btnMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuLogger});
            this.btnMenuFile.Name = "btnMenuFile";
            this.btnMenuFile.Size = new System.Drawing.Size(59, 26);
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
            this.checkIsInterop.Location = new System.Drawing.Point(0, 51);
            this.checkIsInterop.Margin = new System.Windows.Forms.Padding(5);
            this.checkIsInterop.Name = "checkIsInterop";
            this.checkIsInterop.Size = new System.Drawing.Size(906, 21);
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
            this.checkIsEpplus.Location = new System.Drawing.Point(0, 30);
            this.checkIsEpplus.Margin = new System.Windows.Forms.Padding(5);
            this.checkIsEpplus.Name = "checkIsEpplus";
            this.checkIsEpplus.Size = new System.Drawing.Size(906, 21);
            this.checkIsEpplus.TabIndex = 14;
            this.checkIsEpplus.Text = "Использовать EPPlus";
            this.checkIsEpplus.UseVisualStyleBackColor = true;
            this.checkIsEpplus.CheckedChanged += new System.EventHandler(this.checkIsEpplus_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 402);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.checkIsInterop);
            this.Controls.Add(this.checkIsEpplus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(18, 356);
            this.Name = "MainForm";
            this.Text = "XML TO EXCEL";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnAddExcel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnMenuLogger;
        private System.Windows.Forms.CheckBox checkIsInterop;
        private System.Windows.Forms.CheckBox checkIsEpplus;
    }
}

