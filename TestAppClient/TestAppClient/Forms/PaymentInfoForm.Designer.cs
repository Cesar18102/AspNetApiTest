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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.SessionActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.LogOutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportAction = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExcelExportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.PaymentFiltersPanel = new System.Windows.Forms.Panel();
            this.PayerSearchInput = new System.Windows.Forms.TextBox();
            this.PayerSearchLabel = new System.Windows.Forms.Label();
            this.PayedGroup = new System.Windows.Forms.GroupBox();
            this.PayedAndUnpayed = new System.Windows.Forms.RadioButton();
            this.Unpayed = new System.Windows.Forms.RadioButton();
            this.Payed = new System.Windows.Forms.RadioButton();
            this.MyPaymentsOnlyFilter = new System.Windows.Forms.CheckBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDataGridView)).BeginInit();
            this.PaymentFiltersPanel.SuspendLayout();
            this.PayedGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionActions,
            this.PaymentActions,
            this.ExportAction});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(793, 27);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
            // 
            // SessionActions
            // 
            this.SessionActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SessionActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutButton});
            this.SessionActions.Image = ((System.Drawing.Image)(resources.GetObject("SessionActions.Image")));
            this.SessionActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SessionActions.Name = "SessionActions";
            this.SessionActions.Size = new System.Drawing.Size(72, 24);
            this.SessionActions.Text = "Session";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(145, 26);
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
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
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // ExportAction
            // 
            this.ExportAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExportAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelExportButton});
            this.ExportAction.Image = ((System.Drawing.Image)(resources.GetObject("ExportAction.Image")));
            this.ExportAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportAction.Name = "ExportAction";
            this.ExportAction.Size = new System.Drawing.Size(66, 24);
            this.ExportAction.Text = "Export";
            // 
            // ExcelExportButton
            // 
            this.ExcelExportButton.Name = "ExcelExportButton";
            this.ExcelExportButton.Size = new System.Drawing.Size(126, 26);
            this.ExcelExportButton.Text = "Excel";
            this.ExcelExportButton.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // PaymentsDataGridView
            // 
            this.PaymentsDataGridView.AllowUserToAddRows = false;
            this.PaymentsDataGridView.AllowUserToDeleteRows = false;
            this.PaymentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PaymentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.PaymentFiltersPanel.Controls.Add(this.PayerSearchInput);
            this.PaymentFiltersPanel.Controls.Add(this.PayerSearchLabel);
            this.PaymentFiltersPanel.Controls.Add(this.PayedGroup);
            this.PaymentFiltersPanel.Controls.Add(this.MyPaymentsOnlyFilter);
            this.PaymentFiltersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentFiltersPanel.Location = new System.Drawing.Point(0, 336);
            this.PaymentFiltersPanel.Name = "PaymentFiltersPanel";
            this.PaymentFiltersPanel.Size = new System.Drawing.Size(793, 162);
            this.PaymentFiltersPanel.TabIndex = 2;
            // 
            // PayerSearchInput
            // 
            this.PayerSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PayerSearchInput.Location = new System.Drawing.Point(180, 4);
            this.PayerSearchInput.Name = "PayerSearchInput";
            this.PayerSearchInput.Size = new System.Drawing.Size(366, 34);
            this.PayerSearchInput.TabIndex = 3;
            this.PayerSearchInput.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // PayerSearchLabel
            // 
            this.PayerSearchLabel.AutoSize = true;
            this.PayerSearchLabel.Location = new System.Drawing.Point(3, 7);
            this.PayerSearchLabel.Name = "PayerSearchLabel";
            this.PayerSearchLabel.Size = new System.Drawing.Size(171, 29);
            this.PayerSearchLabel.TabIndex = 2;
            this.PayerSearchLabel.Text = "Плательщик: ";
            // 
            // PayedGroup
            // 
            this.PayedGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PayedGroup.Controls.Add(this.PayedAndUnpayed);
            this.PayedGroup.Controls.Add(this.Unpayed);
            this.PayedGroup.Controls.Add(this.Payed);
            this.PayedGroup.Location = new System.Drawing.Point(552, 4);
            this.PayedGroup.Name = "PayedGroup";
            this.PayedGroup.Size = new System.Drawing.Size(238, 147);
            this.PayedGroup.TabIndex = 1;
            this.PayedGroup.TabStop = false;
            this.PayedGroup.Text = "Оплата";
            // 
            // PayedAndUnpayed
            // 
            this.PayedAndUnpayed.AutoSize = true;
            this.PayedAndUnpayed.Checked = true;
            this.PayedAndUnpayed.Location = new System.Drawing.Point(6, 108);
            this.PayedAndUnpayed.Name = "PayedAndUnpayed";
            this.PayedAndUnpayed.Size = new System.Drawing.Size(76, 33);
            this.PayedAndUnpayed.TabIndex = 2;
            this.PayedAndUnpayed.TabStop = true;
            this.PayedAndUnpayed.Text = "Все";
            this.PayedAndUnpayed.UseVisualStyleBackColor = true;
            this.PayedAndUnpayed.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // Unpayed
            // 
            this.Unpayed.AutoSize = true;
            this.Unpayed.Location = new System.Drawing.Point(6, 69);
            this.Unpayed.Name = "Unpayed";
            this.Unpayed.Size = new System.Drawing.Size(211, 33);
            this.Unpayed.TabIndex = 1;
            this.Unpayed.TabStop = true;
            this.Unpayed.Text = "Неоплаченные";
            this.Unpayed.UseVisualStyleBackColor = true;
            this.Unpayed.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // Payed
            // 
            this.Payed.AutoSize = true;
            this.Payed.Location = new System.Drawing.Point(6, 33);
            this.Payed.Name = "Payed";
            this.Payed.Size = new System.Drawing.Size(185, 33);
            this.Payed.TabIndex = 0;
            this.Payed.TabStop = true;
            this.Payed.Text = "Оплаченные";
            this.Payed.UseVisualStyleBackColor = true;
            this.Payed.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // MyPaymentsOnlyFilter
            // 
            this.MyPaymentsOnlyFilter.AutoSize = true;
            this.MyPaymentsOnlyFilter.Checked = true;
            this.MyPaymentsOnlyFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MyPaymentsOnlyFilter.Location = new System.Drawing.Point(12, 126);
            this.MyPaymentsOnlyFilter.Name = "MyPaymentsOnlyFilter";
            this.MyPaymentsOnlyFilter.Size = new System.Drawing.Size(264, 33);
            this.MyPaymentsOnlyFilter.TabIndex = 0;
            this.MyPaymentsOnlyFilter.Text = "Только мои оплаты";
            this.MyPaymentsOnlyFilter.UseVisualStyleBackColor = true;
            this.MyPaymentsOnlyFilter.CheckedChanged += new System.EventHandler(this.MyPaymentsOnlyFilter_CheckedChanged);
            // 
            // PaymentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 498);
            this.Controls.Add(this.PaymentFiltersPanel);
            this.Controls.Add(this.PaymentsDataGridView);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "PaymentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentInfoForm";
            this.Load += new System.EventHandler(this.PaymentInfoForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDataGridView)).EndInit();
            this.PaymentFiltersPanel.ResumeLayout(false);
            this.PaymentFiltersPanel.PerformLayout();
            this.PayedGroup.ResumeLayout(false);
            this.PayedGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripDropDownButton PaymentActions;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridView PaymentsDataGridView;
        private System.Windows.Forms.Panel PaymentFiltersPanel;
        private System.Windows.Forms.CheckBox MyPaymentsOnlyFilter;
        private System.Windows.Forms.GroupBox PayedGroup;
        private System.Windows.Forms.RadioButton PayedAndUnpayed;
        private System.Windows.Forms.RadioButton Unpayed;
        private System.Windows.Forms.RadioButton Payed;
        private System.Windows.Forms.ToolStripDropDownButton ExportAction;
        private System.Windows.Forms.ToolStripMenuItem ExcelExportButton;
        private System.Windows.Forms.TextBox PayerSearchInput;
        private System.Windows.Forms.Label PayerSearchLabel;
        private System.Windows.Forms.ToolStripDropDownButton SessionActions;
        private System.Windows.Forms.ToolStripMenuItem LogOutButton;
    }
}