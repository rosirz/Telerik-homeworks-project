using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    class Display
    {
        //size and number of colors
        private string size;
        private string numberOfColors;
        //Problem 5. Properties

        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.
        public double Size { get; set; }
        public int NumberOfColors { get; set; }

        public Display()
        {
            
        }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int numberOfColors):this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            StringBuilder DisplayInfo = new StringBuilder();
            DisplayInfo.AppendLine("Display size: " + this.Size);
            DisplayInfo.AppendLine("Number of colors: " + this.NumberOfColors);
            return DisplayInfo.ToString();
        }

        //public string DispInfo()
        //{
        //    StringBuilder dInfo = new StringBuilder();
        //    dInfo.AppendLine("Display size: " + this.Size);
        //    dInfo.AppendLine("Number of colors: " + this.NumberOfColors);
        //    return dInfo.ToString();
        //}
    }
}

