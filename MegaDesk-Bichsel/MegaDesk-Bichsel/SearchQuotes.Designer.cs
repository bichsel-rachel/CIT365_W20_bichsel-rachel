namespace MegaDesk_Bichsel
{
    partial class SearchQuotes
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
            this.closeSearchQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeSearchQuotes
            // 
            this.closeSearchQuotes.Location = new System.Drawing.Point(320, 285);
            this.closeSearchQuotes.Name = "closeSearchQuotes";
            this.closeSearchQuotes.Size = new System.Drawing.Size(75, 23);
            this.closeSearchQuotes.TabIndex = 0;
            this.closeSearchQuotes.Text = "Close";
            this.closeSearchQuotes.UseVisualStyleBackColor = true;
            this.closeSearchQuotes.Click += new System.EventHandler(this.closeSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 320);
            this.Controls.Add(this.closeSearchQuotes);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeSearchQuotes;
    }
}