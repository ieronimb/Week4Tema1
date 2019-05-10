using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week4Tema1

        //Problem 1 -> Subpunctul 1: Define a class that holds information about a mobile phone device: model, manufacturer, price, owner
{
    class GSM

    {   //Problem 1 -> Subpunctul 1: Define a class that holds information about a mobile phone device: model, manufacturer, price, owner
        private string gsmModel;
        private string gsmManufacturer;
        private double gsmPrice;
        private string gsmOwner;       
        


        //Problem 2. Constructors -> Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        public GSM(string gsmModel, string gsmManufacturer, double gsmPrice, string gsmOwner)
        {
            this.gsmModel = gsmModel;
            this.gsmManufacturer = gsmManufacturer;
            this.gsmPrice = gsmPrice;
            this.gsmOwner = gsmOwner;

        }

        //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
        public string GsmModel
        {
            get { return this.gsmModel; }

            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Model cannot be empty!");

                this.gsmModel = value;
            }
        }

        public string GsmManufacturer
        {
            get { return this.gsmManufacturer; }

            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Manufacturer cannot be empty!");

                this.gsmManufacturer = value;
            }
        }


        //Problem 6. Static field -> Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        private static GSM iPhone4S;
        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S", "Apple", 100.99, "Unknown");
        }

        //Problem 5. Properties -> Use properties to encapsulate the data fields inside the GSM, Battery and Display classes <GSM>
        //Ensure all fields hold correct data at any given time.
        public string GSMModel
        {
            get { return gsmModel; }
            set { gsmModel = value; }
        }

        public string GSMManufacturer
        {
            get { return gsmManufacturer; }
            set { gsmManufacturer = value; }
        }

        public double GSMPrice
        {
            get { return gsmPrice; }
            set { gsmPrice = value; }
        }

        public string GSMOwner
        {
            get { return gsmOwner; }
            set { gsmOwner = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }      

    }   
}
