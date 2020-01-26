using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bichsel
{
    public enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };
    class Desk
    {
        //initialize variables
        public int width;
        public int depth;
        public int numberDrawers;

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;


        /*Accessor Methods*/
        public float Width()
        {
            return this.width;
        }

        //Width
        public void setWidth(int width)
        {
            this.width = width;
        }

        //Depth
        public float getDepth()
        {
            return this.depth;
        }

        public void setDepth(int depth)
        {
            this.depth = depth;
        }

        //Get and Set Number of Drawers
        public int getNumberDrawers()
        {
            return this.numberDrawers;
        }

        public void setNumberDrawers(int numberDrawers)
        {
            this.numberDrawers = numberDrawers;
        }

        /**
        //Get and Set Surface Material
        public enum getSurfaceMaterial()
        {
            return this.surfaceMaterial;
        }

        public void setSurfaceMaterial(int surfaceMaterial)
        {
            this.surfaceMaterial = surfaceMaterial;
        }
    **/
    }
}
