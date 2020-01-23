namespace MegaDesk_Bichsel
{
    partial class MainMenu
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
            this.ViewAddQuotesForm = new System.Windows.Forms.Button();
            this.ViewQuotesForm = new System.Windows.Forms.Button();
            this.ViewSearchQuotesForm = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewAddQuotesForm
            // 
            this.ViewAddQuotesForm.Location = new System.Drawing.Point(39, 39);
            this.ViewAddQuotesForm.Name = "ViewAddQuotesForm";
            this.ViewAddQuotesForm.Size = new System.Drawing.Size(221, 53);
            this.ViewAddQuotesForm.TabIndex = 0;
            this.ViewAddQuotesForm.Text = "&Add New Quote";
            this.ViewAddQuotesForm.UseVisualStyleBackColor = true;
            this.ViewAddQuotesForm.Click += new System.EventHandler(this.ViewAddQuotesForm_Click);
            // 
            // ViewQuotesForm
            // 
            this.ViewQuotesForm.Location = new System.Drawing.Point(39, 98);
            this.ViewQuotesForm.Name = "ViewQuotesForm";
            this.ViewQuotesForm.Size = new System.Drawing.Size(221, 53);
            this.ViewQuotesForm.TabIndex = 1;
            this.ViewQuotesForm.Text = "&View Quotes";
            this.ViewQuotesForm.UseVisualStyleBackColor = true;
            this.ViewQuotesForm.Click += new System.EventHandler(this.ViewQuotesForm_Click);
            // 
            // ViewSearchQuotesForm
            // 
            this.ViewSearchQuotesForm.Location = new System.Drawing.Point(39, 157);
            this.ViewSearchQuotesForm.Name = "ViewSearchQuotesForm";
            this.ViewSearchQuotesForm.Size = new System.Drawing.Size(221, 53);
            this.ViewSearchQuotesForm.TabIndex = 2;
            this.ViewSearchQuotesForm.Text = "&Search Quotes";
            this.ViewSearchQuotesForm.UseVisualStyleBackColor = true;
            this.ViewSearchQuotesForm.Click += new System.EventHandler(this.ViewSearchQuotesForm_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(39, 216);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(221, 53);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ViewSearchQuotesForm);
            this.Controls.Add(this.ViewQuotesForm);
            this.Controls.Add(this.ViewAddQuotesForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewAddQuotesForm;
        private System.Windows.Forms.Button ViewQuotesForm;
        private System.Windows.Forms.Button ViewSearchQuotesForm;
        private System.Windows.Forms.Button Exit;
    }
}

