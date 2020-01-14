using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05
{
    
    class RandomProducts
    {
        private readonly List<string> producer = new List<string>() {"Bridgestone", "Worldlife", "Timberhouse", "Cliffoods", "Thunderland", "Pumpkin Softwares",
         "Pixystems","Allico","Lagoonfruit","Thunderdale","Electrorks","Goldhut","Blizzart","Waveware","Apple"};
        private readonly List<string> name = new List<string>() {"Ironbark Fusil", "Twilight Rifle", "Stainless Shooter", "Mercenary Shotgun", "Light Slug", "Padded Facemask",
         "Burnished Leather Cap","Barbarian Leather Cowl","Leather Jerkin","Champion's Leather Breastplate","Stormfury Footguards","Engraved Leather Armguards","Warden's Leather Waistband",
         "Heavy Leather Drape","Barbaric Hide Shroud","Diamond","Aquamarine","Jade","Bloodstone","Ring of Power","Emerald","Zircon","Sunstone","Onyx","Moonstone","Spinel","Citrine","Agate",
         "Tanzanite","Wolpertinger Feather","Pegasus Hair","Roc Egg","Vermilion Feather","Yeti Fur","Dragon Blood","Hydra Blood","Arachne's Web","Spriggan Bark","Wyvern Scale","Dragon Claw"};
        public int Count { get; private set; }
        public RandomProducts()
        {
            this.Count = 0;
        }
        public Product Random()
        {
            Random rnd = new Random();
            string barcode = "BSD" + (1000000 + Count * 2);
            double price = rnd.NextDouble() + rnd.NextDouble() * 2 + rnd.NextDouble()*5 +rnd.NextDouble() *7;
            int name = rnd.Next(0, this.name.Count - 1);
            int producer = rnd.Next(0, this.producer.Count - 1);
            var product = new Product(barcode, this.producer[producer], this.name[name], price);
            Count++;
            return product;

        }
    }
}
