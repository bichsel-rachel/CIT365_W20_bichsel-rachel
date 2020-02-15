using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bichsel
{
    class DeskQuote
    {
        //public Desk Desk = new Desk();

        const int BASE_PRICE = 200;
        const int PRICE_PER_DRAWER = 50;
        const int PRICE_PER_INCH = 1;

        //initialize variables
        public Desk desk = new Desk();
        private int drawerPrice;
        private string customerName;
        private int rushOrder;
        private int rushDay;        
        
        public DeskQuote(string CustomerName, int Width, int Depth, int Drawers, int RushDay)
        {
            customerName = CustomerName;
            desk.width = Width;
            desk.depth = Depth;
            desk.numberDrawers = Drawers;
            rushDay = RushDay;
            
        
        
       

        }


        //Accessor Methods

      

        public int setDrawerPrice(int numberDrawers)
        {
            this.drawerPrice = numberDrawers * PRICE_PER_DRAWER;
            return this.drawerPrice;
        }


        //Customer
        public string getCustomerName()
        {
            return this.customerName;
        }

        
        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }



        public int rushOrderPrice(int rushDay, int surfaceArea) {

            int rushOrderPrice = 0;

            if (rushDay == 0) {
                rushOrderPrice = 0;
            }

            if (rushDay == 3)
            {
                if (surfaceArea < 1000)
                { rushOrderPrice = 60; }
                if (surfaceArea >= 1000 && surfaceArea >= 2000)
                { rushOrderPrice = 70; }
                if (surfaceArea > 2000)
                { rushOrderPrice = 80; }
            }

            if (rushDay == 5)
            {
                if (surfaceArea < 1000)
                { rushOrderPrice = 40; }
                if (surfaceArea >= 1000 && surfaceArea >= 2000)
                { rushOrderPrice = 50; }
                if (surfaceArea > 2000)
                { rushOrderPrice = 60; }
            }

            if (rushDay == 7)
            {
                if (surfaceArea < 1000)
                { rushOrderPrice = 30; }
                if (surfaceArea >= 1000 && surfaceArea >= 2000)
                { rushOrderPrice = 35; }
                if (surfaceArea > 2000)
                { rushOrderPrice = 40; }
            }

            return rushOrderPrice;
                
        }

        public int desktopSurfaceArea(int width, int depth)
        {
            int surfaceAreaPrice;
            int desktopSurfaceArea = width * depth;
            if (desktopSurfaceArea < 1000)
            {
                surfaceAreaPrice = 0;
            }
            else
            {
                surfaceAreaPrice = desktopSurfaceArea - 1000;
            }
            return surfaceAreaPrice;
        }

        public int desktopMaterialPrice(string surfaceMaterial)
        {
            int desktopMaterialPrice = 0;

            if(surfaceMaterial == "Oak")
                { desktopMaterialPrice = 200; }
            else if (surfaceMaterial == "Laminate")
                { desktopMaterialPrice = 100; }
            else if (surfaceMaterial == "Pine")
            { desktopMaterialPrice = 50; }
            else if (surfaceMaterial == "Rosewood")
            { desktopMaterialPrice = 300; }
            else if (surfaceMaterial == "Veneer")
            { desktopMaterialPrice = 125; }
            else
            {
                //error
            }
            return desktopMaterialPrice;
        }
        public float setDeskQuote(int width, int depth, int drawers, string surfaceMaterial, int rushDay, int surfaceArea)
        { 
            float deskQuote = BASE_PRICE + desktopSurfaceArea(width, depth) + setDrawerPrice(drawers) + desktopMaterialPrice(surfaceMaterial) + rushOrderPrice(rushDay, surfaceArea);
            return deskQuote;
        }


        //Get Rush Order
        public int[,] GetRushOrder()
        {
            string[] orderPrices = File.ReadAllLines("C:\\Users\\owner\\Desktop\\github\\classes\\cit365\\CIT365_W20_bichsel-rachel\\MegaDesk-Bichsel\\MegaDesk-Bichsel\\rushOrderPrices.txt");
            int[,] rushOrderGrid = new int[3, 3];

            //outer loop for rows, inner for columns
            int x = 0;
            int i;
            int j = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    int output = int.Parse(orderPrices[x]);
                    rushOrderGrid[i, j] = output;
                    MessageBox.Show("Test:" + i + ", " + j + " " + rushOrderGrid[i,j]);
                    x++;
                }
                
            }
            
            return rushOrderGrid;
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

        }



    }


}
