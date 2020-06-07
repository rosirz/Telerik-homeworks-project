using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 8. Calls

//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).
namespace GSM
{
    class Call
    {
        //It should contain date, time, dialled phone number and duration (in seconds).
        private DateTime dateTime;
        private string dialedPhone;
        private long duration;

        public DateTime DateTime { get; set; }
        public string DialedPhone { get; set; }
        public long Duration { get; set; }

        public Call (long duration)
        {
            this.Duration = duration;
        }

        public Call (long duration,DateTime dateTime,string dialedPhone) :this(duration)
        {
            this.DateTime = dateTime;
            this.DialedPhone = dialedPhone;
        }

        public override string ToString()
        {
            StringBuilder CallHistoryInfo = new StringBuilder();
            CallHistoryInfo.AppendLine("Date and time: " + this.DateTime);
            CallHistoryInfo.AppendLine("Duration: " + this.Duration/60 + " minutes");
            CallHistoryInfo.AppendLine("Dialed number: " + this.DialedPhone);

            return CallHistoryInfo.ToString();
        }

    }
}
