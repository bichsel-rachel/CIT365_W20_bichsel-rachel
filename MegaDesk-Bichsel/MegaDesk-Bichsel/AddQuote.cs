using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk_Bichsel;

namespace MegaDesk_Bichsel
{
    public partial class AddQuote : Form
    { 
        string customerName = "";
        int drawers = 0;
        int width;
        int depth;
        int rushDay;
        string surfaceMaterial;


        public AddQuote()
        {
            InitializeComponent();
            materialDropBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenuForm = (MainMenu)Tag;
            viewMainMenuForm.Show();
            Close();
        }

        private void viewDisplayQuoteForm_Click(object sender, EventArgs e)
        {
            customerName = customerNameInput.Text;
            
            width = int.Parse(widthInput.Text);
            surfaceMaterial = materialDropBox.Text;
            drawers = int.Parse(drawersInput.Text);

           
            

           
            

            //set Rush Day to Value
            if (noDayRush.Checked)
                {
                    rushDay = 0;
                }
                else if (threeDayRush.Checked)
                {
                    rushDay = 3;
                }
                else if (fiveDayRush.Checked)
                {
                    rushDay = 5;
                }
                else if (sevenDayRush.Checked)
                {
                    rushDay = 7;
                }
                else
                {
                    rushDay = 0;
                }
            
            
        //Calling Methods
            DeskQuote newQuote = new DeskQuote(customerName, width, depth, drawers, rushDay);
            int drawerPrice = newQuote.setDrawerPrice(drawers);
            int surfaceArea = newQuote.desktopSurfaceArea(width, depth);
            int rushOrderPrice = newQuote.rushOrderPrice(rushDay, surfaceArea);
            int desktopMaterialPrice = newQuote.desktopMaterialPrice(surfaceMaterial);
            float quoteTotal = newQuote.setDeskQuote(width, depth, drawers, surfaceMaterial, rushDay, surfaceArea);
            newQuote.getCustomerName();

            //Testing
            newQuote.GetRushOrder();
            try
            {
                if (!(int.Parse(depthInput.Text) < Desk.MIN_DEPTH)
                || !(int.Parse(depthInput.Text) > Desk.MAX_DEPTH))
                {
                    depth = int.Parse(depthInput.Text);
                }
            }
            catch (FormatException) //when (depthInput.Text == "")
            {
                if (depthInput.Text == "")
                {
                    MessageBox.Show("Depth field empty. Please input depth between 12 and 48.");
                }
                else
                {
                    throw;
                }
                //AddQuote viewAddQuote = new AddQuote();
                //viewAddQuote.Show();

                //throw;

            }

            DisplayQuote toDisplayQuote = new DisplayQuote(customerNameInput.Text, width, depth, drawerPrice, surfaceArea, rushOrderPrice, surfaceMaterial, desktopMaterialPrice, quoteTotal);

           
            toDisplayQuote.Show();

            
            
            Hide();
        }


        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            
            if ((int.Parse(widthInput.Text) < Desk.MIN_WIDTH)
                || (int.Parse(widthInput.Text) > Desk.MAX_WIDTH))
            {
                MessageBox.Show("Width not valid. Width needs to be between 24 and 96");
                widthInput.Text = "24";
            }
        }

       
        private void drawersInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (!(Char.IsDigit(e.KeyChar)) || !(Char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
    }
}
