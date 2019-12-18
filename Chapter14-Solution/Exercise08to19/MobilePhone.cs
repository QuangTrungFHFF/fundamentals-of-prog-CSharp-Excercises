﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08to19
{
    /// <summary>
    /// Ex8 >>>> Define a class, which contains information about a mobile phone: model, manufacturer, price, owner, features of the battery 
    /// (model, idle time and hours talk) and features of the screen (size and colors).
    /// Ex9 >>>> Declare several constructors for each of the classes created by the previous task, which have different lists of parameters 
    /// (for complete information about a student or part of it). Data fields that are unknown have to be initialized respectively with null or 0.
    /// </summary>
    class MobilePhone
    {
        private string model = null;
        private string manufacturer = null;
        private double? price = null;
        private string owner = null;
        private Battery battery;
        private Screen screen;
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
    }
}
