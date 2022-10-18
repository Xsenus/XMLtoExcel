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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuLogger = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIsInterop = new System.Windows.Forms.CheckBox();
            this.checkIsEpplus = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.Location = new System.Drawing.Point(123, 7);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.MinimumSize = new System.Drawing.Size(300, 4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(344, 56);
            this.txtPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Location = new System.Drawing.Point(474, 10);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(300, 50);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "+";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblPath, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtPath, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.btnStart, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.listView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btnSelect, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.btnCancel, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.lblOut, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 253);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(7, 65);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 121);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Excel:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(7, 5);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(112, 60);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "XML:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(123, 188);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(344, 58);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(124, 68);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(342, 115);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(471, 188);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(306, 58);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOut.Location = new System.Drawing.Point(472, 65);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(304, 121);
            this.lblOut.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 331);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar.MaximumSize = new System.Drawing.Size(0, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(784, 30);
            this.progressBar.TabIndex = 11;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
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
            this.checkIsInterop.Location = new System.Drawing.Point(0, 51);
            this.checkIsInterop.Margin = new System.Windows.Forms.Padding(5);
            this.checkIsInterop.Name = "checkIsInterop";
            this.checkIsInterop.Padding = new System.Windows.Forms.Padding(5);
            this.checkIsInterop.Size = new System.Drawing.Size(784, 27);
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
            this.checkIsEpplus.Padding = new System.Windows.Forms.Padding(5);
            this.checkIsEpplus.Size = new System.Drawing.Size(784, 27);
            this.checkIsEpplus.TabIndex = 14;
            this.checkIsEpplus.Text = "Использовать EPPlus";
            this.checkIsEpplus.UseVisualStyleBackColor = true;
            this.checkIsEpplus.CheckedChanged += new System.EventHandler(this.checkIsEpplus_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.checkIsInterop);
            this.Controls.Add(this.checkIsEpplus);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "XML TO EXCEL";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnMenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnMenuLogger;
        private System.Windows.Forms.CheckBox checkIsInterop;
        private System.Windows.Forms.CheckBox checkIsEpplus;
        private System.Windows.Forms.Label lblOut;
    }
}

