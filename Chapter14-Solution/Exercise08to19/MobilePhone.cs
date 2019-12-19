using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08to19
{
    /// <summary>
    /// Ex8 >>>> Define a class, which contains information about a mobile phone: model, manufacturer, price, owner, features of the battery 
    /// (model, idle time and hours talk) and features of the screen (size and colors).
    /// Ex9 >>>> Declare several constructors for each of the classes created by the previous task, which have different lists of parameters 
    /// (for complete information about a student or part of it). Data fields that are unknown have to be initialized respectively with null or 0.
    /// Ex10 >>>> To the class of mobile phone in the previous two tasks, add a static field nokiaN95, which stores information about mobile phone 
    /// model iPhone11. Add a method to the same class, which displays information about this static field.
    /// Ex16 >>>> Add a property for keeping a call history – CallHistory, which holds a list of call records.
    /// Ex17 >>>> In GSM class add methods for adding and deleting calls (Call) in the archive of mobile phone calls. Add method, which deletes all calls from the archive.
    /// </summary>
    class MobilePhone
    {
        private string model = null;
        private string manufacturer = null;
        private double? price = null;
        private string owner = null;
        private Battery battery;
        private Screen screen;
        private List<Call> callHistory = new List<Call>();
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public double? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery BatteryProperty
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Screen Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public static MobilePhone iPhone11ProM
        {
            get
            {
                return new MobilePhone("iPhone 11 Pro Max", "Apple", 1099, null, "Lithium - ion", 25, 80, 7.5 , "black");
            }
        }
        
        public MobilePhone(string model, string manufacturer, double? price, string owner, string batteryModel, int? hoursTalk, int? idleTime, double screenSize, string screenColour)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(batteryModel, hoursTalk, idleTime);
            this.screen = new Screen(screenSize, screenColour);
        }
        public MobilePhone(string model, string manufacturer, double? price, string owner, Battery battery, Screen screen )
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.screen = screen;
        }
        public MobilePhone(string model, string manufacturer, double? price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery();
            this.screen =  new Screen();
        }
        public MobilePhone(string model, string manufacturer, double? price) : this(model,manufacturer,price,null)
        {
        }
        public MobilePhone(string model) : this(model,null,null,null)
        {

        }
        public MobilePhone()
        {
            this.model = null;
            this.manufacturer = null;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.screen = null;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Model name: " + model);
            info.Append(System.Environment.NewLine);
            info.Append("Manufacturer: " + manufacturer);
            info.Append(System.Environment.NewLine);
            info.Append("Price: € " + price );
            info.Append(System.Environment.NewLine);
            info.Append("Owner: " + owner);
            info.Append(System.Environment.NewLine);
            info.Append("Battery info: " + battery.ToString());
            info.Append(System.Environment.NewLine);
            info.Append("Display: " + screen.ToString());
            info.Append(System.Environment.NewLine);
            info.Append("-------------------------------");
            return info.ToString();
        }

        /// <summary>
        /// Add a call to call history list
        /// </summary>
        /// <param name="callTime"></param>
        /// <param name="duration"></param>
        public void AddCall(DateTime callTime, int duration)
        {
            if(callTime != null && duration >0)
            {
                this.CallHistory.Add(new Call(callTime,duration));
            }
            else
            {
                Console.WriteLine("There is no call to add!");
            }
        }
        /// <summary>
        /// Delete a call
        /// </summary>
        /// <param name="call"></param>
        public void DeleteCall(Call call)
        {
            if(CallHistory.Contains(call))
            {
                CallHistory.Remove(call);
            }
            else
            {
                Console.WriteLine("Call is not on history list!");
            }
        }
        /// <summary>
        /// Delete all calls history
        /// </summary>
        public void DeleteAllCall()
        {
            CallHistory.Clear();
            Console.WriteLine("Call History cleared!");
        }

        /// <summary>
        /// Calculate total bill from Call History and Price per Minute
        /// </summary>
        /// <param name="pricePerMinute"></param>
        public void BillCalculator(double pricePerMinute)
        {
            double result = 0;
            foreach(Call c in CallHistory)
            {
                result += pricePerMinute * c.DurationMinutes;
            }
            Console.WriteLine("Total: €" + result);
        }
    }
}
