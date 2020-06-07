using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 1. Define class

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
//battery characteristics(model, hours idle and hours talk) and display characteristics(size and number of colors).
//Define 3 separate classes(class GSM holding instances of the classes Battery and Display).
namespace GSM
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
        //Problem 6. Static field

        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

        private static GSM iPhone = new GSM("Iphone4S","Apple",1200,"Niakoi", new Battery(BatteryType.LiIon,50,6), new Display(4, 256));
        //Problem 9. Call history

        //Add a property CallHistory in the GSM class to hold a list of the performed calls.
        //Try to use the system class List<Call>.
        public List<Call> callHistory = new List<Call>();
        private const double pricePerMinute = 0.37;
        //Problem 5. Properties

        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Owner { get; set; }
        public static GSM Iphone {
            get
            {
                return iPhone;
            }
            set
            {
                iPhone = value;
            }
        }

        //Problem 2. Constructors

        //Define several constructors for the defined classes that take different sets of arguments(the full information 
        //for the class or part of it).
        //Assume that model and manufacturer are mandatory(the others are optional). All unknown data fill with null.

        public GSM (string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        
        public GSM(string model, string manufacturer, double price) : this(model,manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery batteryInfo, Display displayInfo)
            : this(model,manufacturer,price)
        {
            this.Owner = owner;
            this.batteryInfo = batteryInfo;
            this.displayInfo = displayInfo;
        }
        //Problem 4. ToString

        //Add a method in the GSM class for displaying all information about it.
        //Try to override ToString().
        public override string ToString()
        {
            StringBuilder AllInfo = new StringBuilder();
            AllInfo.AppendLine("Model: " + this.Model);
            AllInfo.AppendLine("Manufacturer: " + this.Manufacturer);
            AllInfo.AppendLine("Price: " + this.Price + " Eur");
            AllInfo.AppendLine("Owner: " + this.Owner);
            AllInfo.AppendLine("Battery info ");
            AllInfo.AppendLine (""+this.batteryInfo);
            AllInfo.AppendLine("Display info ");
            AllInfo.AppendLine(""+ this.displayInfo);
            return AllInfo.ToString();
        }
        //Problem 10. Add/Delete calls

        //Add methods in the GSM class for adding and deleting calls from the calls history.
        //Add a method to clear the call history.
        //Problem 11. Call price
        

        //Add a method that calculates the total price of the calls in the call history.
        //Assume the price per minute is fixed and is provided as a parameter.
        public void AddCall (Call newCall)
        {
            callHistory.Add(newCall);
        }

        public void DeleteCall (Call newCall)
        {
            callHistory.Remove( newCall);
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        
        public double CalculatePrice()
        {
            double priceOfCalls = 0;
            foreach (var call in callHistory)
            {
                priceOfCalls += call.Duration / 60 * pricePerMinute;
            }
            return priceOfCalls;
        }

        public void PrintCallHistory()
        {
            if (callHistory.Count == 0)
            {
                Console.WriteLine("There are no records in Call history");
            }
            else
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine(call.ToString());
                }
            }
        }

    }
}
