
namespace ChangeXML.NET.Forms
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtShablon = new System.Windows.Forms.TextBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblParameter = new System.Windows.Forms.Label();
            this.lblShablon = new System.Windows.Forms.Label();
            this.btnParameter = new System.Windows.Forms.Button();
            this.btnShablon = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduct.Location = new System.Drawing.Point(125, 17);
            this.txtProduct.Multiline = true;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(302, 25);
            this.txtProduct.TabIndex = 0;
            // 
            // txtShablon
            // 
            this.txtShablon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShablon.Location = new System.Drawing.Point(125, 97);
            this.txtShablon.Multiline = true;
            this.txtShablon.Name = "txtShablon";
            this.txtShablon.Size = new System.Drawing.Size(302, 25);
            this.txtShablon.TabIndex = 1;
            // 
            // txtParameter
            // 
            this.txtParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParameter.Location = new System.Drawing.Point(125, 57);
            this.txtParameter.Multiline = true;
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(302, 25);
            this.txtParameter.TabIndex = 2;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(32, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(68, 17);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Products:";
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProduct.Location = new System.Drawing.Point(445, 17);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(25, 25);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "...";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.Location = new System.Drawing.Point(15, 60);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(85, 17);
            this.lblParameter.TabIndex = 5;
            this.lblParameter.Text = "Parameters:";
            // 
            // lblShablon
            // 
            this.lblShablon.AutoSize = true;
            this.lblShablon.Location = new System.Drawing.Point(32, 100);
            this.lblShablon.Name = "lblShablon";
            this.lblShablon.Size = new System.Drawing.Size(64, 17);
            this.lblShablon.TabIndex = 6;
            this.lblShablon.Text = "Shablon:";
            // 
            // btnParameter
            // 
            this.btnParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParameter.Location = new System.Drawing.Point(445, 55);
            this.btnParameter.Margin = new System.Windows.Forms.Padding(0);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(25, 25);
            this.btnParameter.TabIndex = 7;
            this.btnParameter.Text = "...";
            this.btnParameter.UseVisualStyleBackColor = true;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // btnShablon
            // 
            this.btnShablon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShablon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShablon.Location = new System.Drawing.Point(445, 100);
            this.btnShablon.Margin = new System.Windows.Forms.Padding(0);
            this.btnShablon.Name = "btnShablon";
            this.btnShablon.Size = new System.Drawing.Size(25, 25);
            this.btnShablon.TabIndex = 8;
            this.btnShablon.Text = "...";
            this.btnShablon.UseVisualStyleBackColor = true;
            this.btnShablon.Click += new System.EventHandler(this.btnShablon_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(255, 154);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 30);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnShablon);
            this.Controls.Add(this.btnParameter);
            this.Controls.Add(this.lblShablon);
            this.Controls.Add(this.lblParameter);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.txtShablon);
            this.Controls.Add(this.txtProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainForm";
            this.Text = "ChangeXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtShablon;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.Label lblShablon;
        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.Button btnShablon;
        private System.Windows.Forms.Button btnStart;
    }
}

