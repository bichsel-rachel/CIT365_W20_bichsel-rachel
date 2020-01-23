using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bichsel
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenuForm = (MainMenu)Tag;
            viewMainMenuForm.Show();
            Close();
        }

        private void viewDisplayQuoteForm_Click(object sender, EventArgs e)
        {
            DisplayQuote viewDisplayQuoteForm = new DisplayQuote();
            viewDisplayQuoteForm.Tag = this;
            viewDisplayQuoteForm.Show(this);
            Hide();
        }
    }
}
