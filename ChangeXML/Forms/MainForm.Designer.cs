
namespace ChangeXML.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnProduct = new DevExpress.XtraEditors.ButtonEdit();
            this.btnParameter = new DevExpress.XtraEditors.ButtonEdit();
            this.btnShablon = new DevExpress.XtraEditors.ButtonEdit();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabbedControlGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemShablon = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemParameter = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemProduct = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShablon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShablon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.btnProduct);
            this.layoutControl.Controls.Add(this.btnParameter);
            this.layoutControl.Controls.Add(this.btnShablon);
            this.layoutControl.Controls.Add(this.btnStart);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(490, 215);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(103, 46);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnProduct.Size = new System.Drawing.Size(367, 22);
            this.btnProduct.StyleController = this.layoutControl;
            this.btnProduct.TabIndex = 4;
            this.btnProduct.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnProduct_ButtonPressed);
            // 
            // btnParameter
            // 
            this.btnParameter.Location = new System.Drawing.Point(103, 72);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnParameter.Size = new System.Drawing.Size(367, 22);
            this.btnParameter.StyleController = this.layoutControl;
            this.btnParameter.TabIndex = 5;
            this.btnParameter.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnParameter_ButtonPressed);
            // 
            // btnShablon
            // 
            this.btnShablon.Location = new System.Drawing.Point(103, 98);
            this.btnShablon.Name = "btnShablon";
            this.btnShablon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnShablon.Size = new System.Drawing.Size(367, 22);
            this.btnShablon.StyleController = this.layoutControl;
            this.btnShablon.TabIndex = 6;
            this.btnShablon.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnShablon_ButtonPressed);
            // 
            // btnStart
            // 
            this.btnStart.AllowFocus = false;
            this.btnStart.Location = new System.Drawing.Point(7, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(476, 27);
            this.btnStart.StyleController = this.layoutControl;
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Root.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemStart,
            this.emptySpaceItem,
            this.tabbedControlGroup});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(490, 215);
            this.Root.TextVisible = false;
            // 
            // layoutControlItemStart
            // 
            this.layoutControlItemStart.Control = this.btnStart;
            this.layoutControlItemStart.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItemStart.Name = "layoutControlItemStart";
            this.layoutControlItemStart.Size = new System.Drawing.Size(480, 31);
            this.layoutControlItemStart.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemStart.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 130);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(480, 44);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabbedControlGroup
            // 
            this.tabbedControlGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup.Name = "tabbedControlGroup";
            this.tabbedControlGroup.SelectedTabPage = this.layoutControlGroup;
            this.tabbedControlGroup.Size = new System.Drawing.Size(480, 130);
            this.tabbedControlGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup});
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemShablon,
            this.layoutControlItemParameter,
            this.layoutControlItemProduct});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(455, 78);
            this.layoutControlGroup.Text = "XML Files";
            // 
            // layoutControlItemShablon
            // 
            this.layoutControlItemShablon.Control = this.btnShablon;
            this.layoutControlItemShablon.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItemShablon.Name = "layoutControlItemShablon";
            this.layoutControlItemShablon.Size = new System.Drawing.Size(455, 26);
            this.layoutControlItemShablon.Text = "Shablon:";
            this.layoutControlItemShablon.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItemParameter
            // 
            this.layoutControlItemParameter.Control = this.btnParameter;
            this.layoutControlItemParameter.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItemParameter.Name = "layoutControlItemParameter";
            this.layoutControlItemParameter.Size = new System.Drawing.Size(455, 26);
            this.layoutControlItemParameter.Text = "Parameters:";
            this.layoutControlItemParameter.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItemProduct
            // 
            this.layoutControlItemProduct.Control = this.btnProduct;
            this.layoutControlItemProduct.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemProduct.Name = "layoutControlItemProduct";
            this.layoutControlItemProduct.Size = new System.Drawing.Size(455, 26);
            this.layoutControlItemProduct.Text = "Products:";
            this.layoutControlItemProduct.TextSize = new System.Drawing.Size(81, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 215);
            this.Controls.Add(this.layoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainForm";
            this.Text = "ChangeXML";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShablon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShablon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ButtonEdit btnProduct;
        private DevExpress.XtraEditors.ButtonEdit btnParameter;
        private DevExpress.XtraEditors.ButtonEdit btnShablon;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemStart;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemShablon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemParameter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProduct;
    }
}

