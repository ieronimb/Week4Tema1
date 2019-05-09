using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema1
{           //Define 3 separate classes (class GSM holding instances of the classes Battery and Display)  - <Battery>

    class Battery
    {
        //Problem 3. Enumeration: Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

        public enum BatteryType
        {
            NiMH, NiCd, LiPo, LiIon
        }

        //Problem 1. Define class -> battery characteristics (model, hours idle and hours talk)
        private BatteryType batteryModel;
        private int batteryHoursIdle;
        private int batteryHoursTalk;

        //Problem 2. Constructors -> Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).

        public Battery(BatteryType batteryModel, int batteryHoursIdle, int batteryHoursTalk)
        {
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
        }

        //Problem 5. Properties -> Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. <Battery>
        //Ensure all fields hold correct data at any given time.

        public BatteryType BatteryModel
        {
            get { return batteryModel; }
            set { batteryModel = value; }
        }

        public int BatteryHoursIdle
        {
            get { return batteryHoursIdle; }
            set { batteryHoursIdle = value; }
        }

        public int BatteryHoursTalk
        {
            get { return batteryHoursTalk; }
            set { batteryHoursTalk = value; }
        }
    }
}
