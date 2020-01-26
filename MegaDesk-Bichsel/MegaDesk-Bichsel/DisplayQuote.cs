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

    public partial class DisplayQuote : Form
    {
        //DeskQuote deskQuote = new DeskQuote();

        
        public DisplayQuote(string customerName, int width, int depth, int drawers, int surfaceArea, int rushOrderPrice, string surfaceMaterial, int desktopMaterialPrice, float quoteTotal)
        {
            InitializeComponent();

            customerNameDisplay.Text = customerName;
            widthResult.Text = width.ToString();
            depthResult.Text = depth.ToString();
            drawersResult.Text = drawers.ToString();
            surfaceAreaResult.Text = surfaceArea.ToString();
            basePriceResult.Text = "200";
            rushOrderPriceResult.Text = rushOrderPrice.ToString();
            surfaceMaterialTypeResult.Text = surfaceMaterial;
            surfaceMaterialPriceResult.Text = desktopMaterialPrice.ToString();
            deskQuoteTotalResult.Text = quoteTotal.ToString();
            
        }

        
        private void closeDisplayQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenuForm = (MainMenu)Tag;
            viewMainMenuForm.Show();
            Close();

        }

        //public void setAll(DeskQuote deskQuote)
        //{
        //    this.customerName = deskQuote.customerName;
        //    this.drawerPrice = deskQuote.drawerPrice;
        //}

        public void setCustomerName(string customerName)
        {
            customerNameDisplay.Text = customerName;
        }

        public void setDrawersPrice(string drawers)
        {
            int drawersTest = int.Parse(drawers) * 50;
            drawersResult.Text = drawersTest.ToString();
        }

        public void setMaterial(string material)
        {
            surfaceMaterialPriceResult.Text = material;
        }
    }
}
