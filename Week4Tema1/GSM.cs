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

        //Problem 6. Static field -> Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        private static GSM iPhone4S;
        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S", "Apple", 100.99, "Unknown");
        }

        ////Problem 5. Properties -> Use properties to encapsulate the data fields inside the GSM, Battery and Display classes <GSM>
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

        //Problem 4. ToString -> Add a method in the GSM class for displaying all information about it.
        //Try to override ToString().
        public override string ToString()
        {           
            Console.WriteLine("Model: {0}.",this.gsmModel);
            Console.WriteLine("Manufacturer: {0}.",this.gsmManufacturer);
            Console.WriteLine("Price: {0} euro.", this.gsmPrice);
            Console.WriteLine("Owner: {0}.",this.gsmOwner);
            Console.WriteLine();
            return ToString();
        }       
    }
}
