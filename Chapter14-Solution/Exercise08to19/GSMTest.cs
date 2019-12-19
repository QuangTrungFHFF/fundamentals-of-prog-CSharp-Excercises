using System;
using System.Collections.Generic;

namespace Exercise08to19
{
    /// <summary>
    /// Ex14. Write a class GSMTest, which has to test the functionality of class GSM. 
    /// Create few objects of the class and store them into a List. 
    /// Display information about the created objects. 
    /// Display information about the static field nokiaN95.
    /// </summary>
    class GSMTest
    {        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Create few objects of the class and store them into a List. 
            List<MobilePhone> GSMList = new List<MobilePhone>();
            MobilePhone samsungN10 = new MobilePhone("Samsung Note 10", "Samsung", 949, "Tran Quang Trung", new Battery("Li-Ion", 25, 90), new Screen(6.5, "Aura Glow"));
            MobilePhone samsungN10P = new MobilePhone("Samsung Note 10 Plus", "Samsung", 1199, "Tran Thi Bich Ngoc","Li-Ion",27,95,6.8,"Aura Black");
            MobilePhone huaweiM30P = new MobilePhone("Huawei Mate 30 Pro", "Huawei", 1099,"Tran Thi Bich Ngoc");
            MobilePhone iPhone11 = new MobilePhone("iPhone 11", "Apple", 699);
            GSMList.Add(samsungN10);
            GSMList.Add(samsungN10P);
            GSMList.Add(huaweiM30P);
            GSMList.Add(iPhone11);
            // Display information about the created objects. 
            foreach(MobilePhone p in GSMList)
            {
                Console.WriteLine(p.ToString());
            }
            // Display information about the static field nokiaN95.
            Console.WriteLine(MobilePhone.iPhone11ProM.ToString());
            Console.ReadKey(true);

        }        
    }
}
