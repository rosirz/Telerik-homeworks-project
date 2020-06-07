using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 12. Call history test

//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.
namespace GSM
{
    class GSMCallHistoryTest
    {
        public void TestCallHistory()
        {
            var newGSM = new GSM("OT Popstar", "Alkatel");
            newGSM.AddCall(new Call(600,new DateTime(2016,05,26,15,4,02), "359887654321"));
            newGSM.AddCall(new Call(350, new DateTime(2016, 05, 27, 12, 2, 10), "359885463854"));
            newGSM.AddCall(new Call(424, new DateTime(2016, 05, 27, 13, 24, 21), "359889563841"));
            newGSM.AddCall(new Call(500, new DateTime(2016, 05, 27, 22, 56, 13), "359887654321"));
            newGSM.PrintCallHistory();
            Console.WriteLine("The price of total calls is " +  newGSM.CalculatePrice());
            newGSM.DeleteCall(newGSM.callHistory[CheckLongestCall(newGSM)]);
            Console.WriteLine("The price of total calls without the longest call is " + newGSM.CalculatePrice());
            newGSM.ClearHistory();
            newGSM.PrintCallHistory();


        }
        public int CheckLongestCall(GSM newGSM)
        {
            int index = 0;
            for (int i = 0; i < newGSM.callHistory.Count - 1; i++)
            {
                if (newGSM.callHistory[i].Duration < newGSM.callHistory[i + 1].Duration)
                {
                    index = i + 1;
                }
            }
            return index;
        }




    }
}
