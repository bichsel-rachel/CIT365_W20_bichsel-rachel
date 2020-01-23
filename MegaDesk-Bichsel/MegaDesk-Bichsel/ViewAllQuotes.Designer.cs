namespace MegaDesk_Bichsel
{
    partial class ViewAllQuotes
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
            this.closeViewAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeViewAllQuotes
            // 
            this.closeViewAllQuotes.Location = new System.Drawing.Point(341, 308);
            this.closeViewAllQuotes.Name = "closeViewAllQuotes";
            this.closeViewAllQuotes.Size = new System.Drawing.Size(75, 23);
            this.closeViewAllQuotes.TabIndex = 0;
            this.closeViewAllQuotes.Text = "close";
            this.closeViewAllQuotes.UseVisualStyleBackColor = true;
            this.closeViewAllQuotes.Click += new System.EventHandler(this.closeViewAllQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 343);
            this.Controls.Add(this.closeViewAllQuotes);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeViewAllQuotes;
    }
}