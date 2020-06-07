using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 7. GSM test

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.
namespace GSM
{
    class GSMTest
    {
        public GSM[] gsm =
        {
            new GSM("Galaxy", "Samsung"),
            new GSM("One A9S", "HTC", 579.99),
            new GSM("Moto Z", "Lenovo", 939.99, "Mr. B", new Battery(BatteryType.LiIon, 300, 6), new Display(5.5)),
            new GSM("Xperia", "Sony", 699.99, "Mrs. D", new Battery(), new Display(4.6)),
            new GSM("K4", "LG", 99.99, "Son of Mr. B", new Battery(BatteryType.LiIon, 500, 9), new Display(4.5))

        };

       

       public void Display (int start,int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(gsm[i].ToString());
            }

            Console.WriteLine(GSM.Iphone.ToString());
        }


    }
}
