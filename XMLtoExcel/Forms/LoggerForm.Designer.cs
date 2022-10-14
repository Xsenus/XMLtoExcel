
namespace XMLtoExcel.Forms
{
    partial class LoggerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerForm));
            this.memoLogger = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // memoLogger
            // 
            this.memoLogger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memoLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoLogger.Location = new System.Drawing.Point(0, 0);
            this.memoLogger.Name = "memoLogger";
            this.memoLogger.ReadOnly = true;
            this.memoLogger.Size = new System.Drawing.Size(800, 450);
            this.memoLogger.TabIndex = 0;
            this.memoLogger.Text = "";
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memoLogger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoggerForm";
            this.Text = "LoggerForm";
            this.Load += new System.EventHandler(this.LoggerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox memoLogger;
    }
}