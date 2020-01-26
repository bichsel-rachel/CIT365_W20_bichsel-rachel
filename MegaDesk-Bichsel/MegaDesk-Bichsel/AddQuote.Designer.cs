namespace MegaDesk_Bichsel
{
    partial class AddQuote
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
            this.closeAddQuote = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.TextBox();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.TextBox();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.threeDayRush = new System.Windows.Forms.RadioButton();
            this.fiveDayRush = new System.Windows.Forms.RadioButton();
            this.sevenDayRush = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.materialDropBox = new System.Windows.Forms.ComboBox();
            this.materialTypeLabel = new System.Windows.Forms.TextBox();
            this.addNewQuoteLabel = new System.Windows.Forms.TextBox();
            this.viewDisplayQuoteForm = new System.Windows.Forms.Button();
            this.noDayRush = new System.Windows.Forms.RadioButton();
            this.width_min_max = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAddQuote
            // 
            this.closeAddQuote.Location = new System.Drawing.Point(330, 367);
            this.closeAddQuote.Name = "closeAddQuote";
            this.closeAddQuote.Size = new System.Drawing.Size(75, 23);
            this.closeAddQuote.TabIndex = 0;
            this.closeAddQuote.Text = "Close";
            this.closeAddQuote.UseVisualStyleBackColor = true;
            this.closeAddQuote.Click += new System.EventHandler(this.closeAddQuote_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(293, 98);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(57, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(293, 148);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(57, 20);
            this.depthInput.TabIndex = 3;
            // 
            // widthLabel
            // 
            this.widthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.widthLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(12, 103);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(100, 15);
            this.widthLabel.TabIndex = 12;
            this.widthLabel.TabStop = false;
            this.widthLabel.Text = "Enter Width";
            // 
            // depthLabel
            // 
            this.depthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.depthLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(12, 148);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(100, 15);
            this.depthLabel.TabIndex = 0;
            this.depthLabel.TabStop = false;
            this.depthLabel.Text = "Enter Depth";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(215, 59);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(135, 20);
            this.customerNameInput.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.customerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(12, 60);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(100, 15);
            this.customerNameLabel.TabIndex = 12;
            this.customerNameLabel.TabStop = false;
            this.customerNameLabel.Text = "Enter Full Name";
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(293, 191);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(57, 20);
            this.drawersInput.TabIndex = 4;
     
            this.drawersInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drawersInput_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Number of Drawers";
            // 
            // threeDayRush
            // 
            this.threeDayRush.AutoSize = true;
            this.threeDayRush.Location = new System.Drawing.Point(215, 246);
            this.threeDayRush.Name = "threeDayRush";
            this.threeDayRush.Size = new System.Drawing.Size(53, 17);
            this.threeDayRush.TabIndex = 5;
            this.threeDayRush.TabStop = true;
            this.threeDayRush.Text = "3 Day";
            this.threeDayRush.UseVisualStyleBackColor = true;
            // 
            // fiveDayRush
            // 
            this.fiveDayRush.AutoSize = true;
            this.fiveDayRush.Location = new System.Drawing.Point(215, 269);
            this.fiveDayRush.Name = "fiveDayRush";
            this.fiveDayRush.Size = new System.Drawing.Size(53, 17);
            this.fiveDayRush.TabIndex = 6;
            this.fiveDayRush.TabStop = true;
            this.fiveDayRush.Text = "5 Day";
            this.fiveDayRush.UseVisualStyleBackColor = true;
            // 
            // sevenDayRush
            // 
            this.sevenDayRush.AutoSize = true;
            this.sevenDayRush.Location = new System.Drawing.Point(215, 292);
            this.sevenDayRush.Name = "sevenDayRush";
            this.sevenDayRush.Size = new System.Drawing.Size(53, 17);
            this.sevenDayRush.TabIndex = 7;
            this.sevenDayRush.TabStop = true;
            this.sevenDayRush.Text = "7 Day";
            this.sevenDayRush.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Rush Order";
            // 
            // materialDropBox
            // 
            this.materialDropBox.FormattingEnabled = true;
            this.materialDropBox.Location = new System.Drawing.Point(215, 321);
            this.materialDropBox.Name = "materialDropBox";
            this.materialDropBox.Size = new System.Drawing.Size(135, 21);
            this.materialDropBox.TabIndex = 8;
            // 
            // materialTypeLabel
            // 
            this.materialTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.materialTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeLabel.Location = new System.Drawing.Point(12, 327);
            this.materialTypeLabel.Name = "materialTypeLabel";
            this.materialTypeLabel.Size = new System.Drawing.Size(100, 15);
            this.materialTypeLabel.TabIndex = 0;
            this.materialTypeLabel.TabStop = false;
            this.materialTypeLabel.Text = "Surface Material";
            // 
            // addNewQuoteLabel
            // 
            this.addNewQuoteLabel.BackColor = System.Drawing.SystemColors.Control;
            this.addNewQuoteLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addNewQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuoteLabel.Location = new System.Drawing.Point(131, 12);
            this.addNewQuoteLabel.Name = "addNewQuoteLabel";
            this.addNewQuoteLabel.Size = new System.Drawing.Size(156, 19);
            this.addNewQuoteLabel.TabIndex = 15;
            this.addNewQuoteLabel.Text = "Add New Quote";
            this.addNewQuoteLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewDisplayQuoteForm
            // 
            this.viewDisplayQuoteForm.Location = new System.Drawing.Point(131, 367);
            this.viewDisplayQuoteForm.Name = "viewDisplayQuoteForm";
            this.viewDisplayQuoteForm.Size = new System.Drawing.Size(132, 23);
            this.viewDisplayQuoteForm.TabIndex = 16;
            this.viewDisplayQuoteForm.Text = "Add Quote";
            this.viewDisplayQuoteForm.UseVisualStyleBackColor = true;
            this.viewDisplayQuoteForm.Click += new System.EventHandler(this.viewDisplayQuoteForm_Click);
            // 
            // noDayRush
            // 
            this.noDayRush.AutoSize = true;
            this.noDayRush.Location = new System.Drawing.Point(215, 225);
            this.noDayRush.Name = "noDayRush";
            this.noDayRush.Size = new System.Drawing.Size(145, 17);
            this.noDayRush.TabIndex = 17;
            this.noDayRush.TabStop = true;
            this.noDayRush.Text = "None - Standard 14 Days";
            this.noDayRush.UseVisualStyleBackColor = true;
            // 
            // width_min_max
            // 
            this.width_min_max.BackColor = System.Drawing.SystemColors.Control;
            this.width_min_max.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.width_min_max.Location = new System.Drawing.Point(12, 121);
            this.width_min_max.Name = "width_min_max";
            this.width_min_max.Size = new System.Drawing.Size(184, 13);
            this.width_min_max.TabIndex = 18;
            this.width_min_max.TabStop = false;
            this.width_min_max.Text = "min 24 inches and max 96 inches";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 13);
            this.textBox3.TabIndex = 19;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "min 12 inches and max 48 inches";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 403);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.width_min_max);
            this.Controls.Add(this.noDayRush);
            this.Controls.Add(this.viewDisplayQuoteForm);
            this.Controls.Add(this.addNewQuoteLabel);
            this.Controls.Add(this.materialTypeLabel);
            this.Controls.Add(this.materialDropBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sevenDayRush);
            this.Controls.Add(this.fiveDayRush);
            this.Controls.Add(this.threeDayRush);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.closeAddQuote);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAddQuote;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.TextBox widthLabel;
        private System.Windows.Forms.TextBox depthLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.TextBox customerNameLabel;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton threeDayRush;
        private System.Windows.Forms.RadioButton fiveDayRush;
        private System.Windows.Forms.RadioButton sevenDayRush;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox materialDropBox;
        private System.Windows.Forms.TextBox materialTypeLabel;
        private System.Windows.Forms.TextBox addNewQuoteLabel;
        private System.Windows.Forms.Button viewDisplayQuoteForm;
        private System.Windows.Forms.RadioButton noDayRush;
        private System.Windows.Forms.TextBox width_min_max;
        private System.Windows.Forms.TextBox textBox3;
    }
}