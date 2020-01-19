using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Ex19 >>>> Create a class GSMCallHistoryTest, with which to test the functionality of the class GSM, from task 12, as an object of type GSM. 
/// Then add to it a few phone calls (Call). Display information about each phone call. Assuming that the price per minute is 0.37, calculate and display the total cost of all calls. 
/// Remove the longest conversation from archive with phone calls and calculate the total price for all calls again. Finally, clear the archive.
/// </summary>
namespace Exercise08to19
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Add a few phone calls
            MobilePhone samsungN10 = new MobilePhone("Samsung Note 10", "Samsung", 949, "Tran Quang Trung", new Battery("Li-Ion", 25, 90), new Screen(6.5, "Aura Glow"));
            samsungN10.AddCall(DateTime.Now, 30);
            samsungN10.AddCall(DateTime.Now.AddDays(2.5), 40);
            samsungN10.AddCall(DateTime.Now.AddDays(7.5), 80);
            //Print call history information
            samsungN10.GetCallHistoryInfo();
            //Calculate the total price for all calls
            samsungN10.BillCalculator(0.37);
            //Remove the longest conversation from archive with phone calls and calculate the total price for all calls again
            samsungN10.CallHistory.Sort();
            samsungN10.DeleteCall(samsungN10.CallHistory[samsungN10.CallHistory.Count-1]);
            samsungN10.GetCallHistoryInfo();
            samsungN10.BillCalculator(0.37);
            //Clear the archive
            samsungN10.DeleteAllCall();
            samsungN10.GetCallHistoryInfo();
            Console.ReadKey();
        }


    }
}
