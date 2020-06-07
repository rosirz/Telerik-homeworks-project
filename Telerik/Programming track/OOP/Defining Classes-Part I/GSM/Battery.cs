using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Battery
    {

        //model, hours idle and hours talk
        private string batteryModel ;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;
        //Problem 5. Properties

        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.
        public string BatteryModel { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }

        public Battery()
        {
            this.BatteryModel = "n/a";
        }

        public Battery ( BatteryType batteryType) :this()
        {
            this.batteryType = batteryType;
        }

        public Battery(BatteryType batteryType, double hoursIdle, double hoursTalk):this(batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            StringBuilder BatteryInfo = new StringBuilder();
            BatteryInfo.AppendLine("Battery model: " + this.BatteryModel);
            BatteryInfo.AppendLine("Hours Idle: " + this.HoursIdle);
            BatteryInfo.AppendLine("Hours Talk: " + this.HoursTalk);
            BatteryInfo.AppendLine("Battery Type: " + this.batteryType);
            return BatteryInfo.ToString();
        }

    }
}
