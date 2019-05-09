using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema1

        //Problem 1. Define class
        //Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
        //battery characteristics(model, hours idle and hours talk) 
        //and display characteristics(size and number of colors).
        //Define 3 separate classes(class GSM holding instances of the classes Battery and Display).
{
    class GSM
    {   //Fields
        private string Model;
        private string Manufacturer;
        private double Price;
        private string Owner;

        //Constructors
        public GSM (string Model, string Manufacturer, double Price, string Owner)
        {
            this.Model = Model;
            this.Manufacturer = Manufacturer;
            this.Price = Price;
            this.Owner = Owner;
        }

    }
}
