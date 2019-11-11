namespace TestAppClient.Forms
{
    partial class PaymentAddForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PatronymicInput = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.ConfirmPaymentButton = new TestAppClient.CustomControls.CustomButton();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountInput = new System.Windows.Forms.NumericUpDown();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.TimeInput = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PayedInput = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(11, 15);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(75, 29);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Имя: ";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameInput.Location = new System.Drawing.Point(186, 12);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(285, 34);
            this.FirstNameInput.TabIndex = 1;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameInput.Location = new System.Drawing.Point(186, 52);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(285, 34);
            this.LastNameInput.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(11, 55);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(135, 29);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия: ";
            // 
            // PatronymicInput
            // 
            this.PatronymicInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicInput.Location = new System.Drawing.Point(186, 92);
            this.PatronymicInput.Name = "PatronymicInput";
            this.PatronymicInput.Size = new System.Drawing.Size(285, 34);
            this.PatronymicInput.TabIndex = 3;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(11, 95);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(135, 29);
            this.PatronymicLabel.TabIndex = 4;
            this.PatronymicLabel.Text = "Отчество: ";
            // 
            // ConfirmPaymentButton
            // 
            this.ConfirmPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPaymentButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ConfirmPaymentButton.BorderWidth = 5F;
            this.ConfirmPaymentButton.CornerBackColor = System.Drawing.SystemColors.Control;
            this.ConfirmPaymentButton.CornerRadius = 20;
            this.ConfirmPaymentButton.DefBackColor = System.Drawing.SystemColors.Control;
            this.ConfirmPaymentButton.EnteredBackColor = System.Drawing.Color.LightSkyBlue;
            this.ConfirmPaymentButton.EnteredBorderWidth = 7F;
            this.ConfirmPaymentButton.Location = new System.Drawing.Point(11, 337);
            this.ConfirmPaymentButton.Name = "ConfirmPaymentButton";
            this.ConfirmPaymentButton.Size = new System.Drawing.Size(459, 104);
            this.ConfirmPaymentButton.Smooth = 10;
            this.ConfirmPaymentButton.TabIndex = 8;
            this.ConfirmPaymentButton.Text = "Подтвердить";
            this.ConfirmPaymentButton.UseVisualStyleBackColor = true;
            this.ConfirmPaymentButton.Click += new System.EventHandler(this.ConfirmPaymentButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(11, 135);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(102, 29);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Сумма: ";
            // 
            // AmountInput
            // 
            this.AmountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountInput.DecimalPlaces = 2;
            this.AmountInput.Location = new System.Drawing.Point(186, 132);
            this.AmountInput.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.AmountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(285, 34);
            this.AmountInput.TabIndex = 4;
            this.AmountInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(11, 175);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 29);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Дата: ";
            // 
            // DateInput
            // 
            this.DateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInput.Location = new System.Drawing.Point(186, 172);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(285, 34);
            this.DateInput.TabIndex = 5;
            // 
            // TimeInput
            // 
            this.TimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeInput.Location = new System.Drawing.Point(186, 212);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.Size = new System.Drawing.Size(285, 34);
            this.TimeInput.TabIndex = 6;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(11, 215);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(101, 29);
            this.TimeLabel.TabIndex = 11;
            this.TimeLabel.Text = "Время: ";
            // 
            // PayedInput
            // 
            this.PayedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PayedInput.AutoSize = true;
            this.PayedInput.Location = new System.Drawing.Point(186, 252);
            this.PayedInput.Name = "PayedInput";
            this.PayedInput.Size = new System.Drawing.Size(154, 33);
            this.PayedInput.TabIndex = 7;
            this.PayedInput.Text = "Оплачено";
            this.PayedInput.UseVisualStyleBackColor = true;
            // 
            // PaymentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.PayedInput);
            this.Controls.Add(this.TimeInput);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AmountInput);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ConfirmPaymentButton);
            this.Controls.Add(this.PatronymicInput);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(430, 450);
            this.Name = "PaymentAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox PatronymicInput;
        private System.Windows.Forms.Label PatronymicLabel;
        private CustomControls.CustomButton ConfirmPaymentButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.NumericUpDown AmountInput;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.DateTimePicker TimeInput;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.CheckBox PayedInput;
    }
}