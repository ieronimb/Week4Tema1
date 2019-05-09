using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema1
{        //Define 3 separate classes (class GSM holding instances of the classes Battery and Display)  - <Display>
    class Display
    {
        ////Problem 1. Define class -> display characteristics (size and number of colors).
        private double DisplaySize;
        private string DisplayColor;

        ////Problem 2. Constructors -> Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        public Display(double DisplaySize, string DisplayColor)
        {
            this.displaySize = DisplaySize;
            this.DisplayColor = DisplayColor;
        }

        // //Problem 5. Properties -> Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. <Display>
        //Ensure all fields hold correct data at any given time.

        public double displaySize
        {
            get { return DisplaySize; }
            set { DisplaySize = value; }
        }

        public string DisplayColors
        {
            get { return DisplayColor; }
            set { DisplayColor = value; }
        }
    }
}
