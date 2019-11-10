namespace TestAppClient.Forms
{
    partial class PaymentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentInfoForm));
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.PaymentActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.PaymentFiltersPanel = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaymentActions});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(793, 27);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
            // 
            // PaymentActions
            // 
            this.PaymentActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PaymentActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.PaymentActions.Image = ((System.Drawing.Image)(resources.GetObject("PaymentActions.Image")));
            this.PaymentActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaymentActions.Name = "PaymentActions";
            this.PaymentActions.Size = new System.Drawing.Size(79, 24);
            this.PaymentActions.Text = "Payment";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // PaymentsDataGridView
            // 
            this.PaymentsDataGridView.AllowUserToAddRows = false;
            this.PaymentsDataGridView.AllowUserToDeleteRows = false;
            this.PaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.PaymentsDataGridView.Name = "PaymentsDataGridView";
            this.PaymentsDataGridView.ReadOnly = true;
            this.PaymentsDataGridView.RowHeadersVisible = false;
            this.PaymentsDataGridView.RowHeadersWidth = 51;
            this.PaymentsDataGridView.RowTemplate.Height = 24;
            this.PaymentsDataGridView.Size = new System.Drawing.Size(793, 303);
            this.PaymentsDataGridView.TabIndex = 1;
            // 
            // PaymentFiltersPanel
            // 
            this.PaymentFiltersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentFiltersPanel.Location = new System.Drawing.Point(0, 336);
            this.PaymentFiltersPanel.Name = "PaymentFiltersPanel";
            this.PaymentFiltersPanel.Size = new System.Drawing.Size(793, 117);
            this.PaymentFiltersPanel.TabIndex = 2;
            // 
            // PaymentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.PaymentFiltersPanel);
            this.Controls.Add(this.PaymentsDataGridView);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PaymentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentInfoForm";
            this.Load += new System.EventHandler(this.PaymentInfoForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripDropDownButton PaymentActions;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridView PaymentsDataGridView;
        private System.Windows.Forms.Panel PaymentFiltersPanel;
    }
}