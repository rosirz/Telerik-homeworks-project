using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var gsmTest = new GSMTest();
            gsmTest.Display(0,5);
            var gsmCallHistoryTest = new GSMCallHistoryTest();
            gsmCallHistoryTest.TestCallHistory();
           
             
            
            
        }
    }

}
