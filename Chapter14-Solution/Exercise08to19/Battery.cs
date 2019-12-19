using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise08to19
{
    class Battery
    {
        private string model = null;
        private int? hoursTalk =null;
        private int? idleTime =null;
        private BatteryTypes batteryTypes; 
        enum BatteryTypes { LiIon, NiMH, NiCd, LiPol }   
        
        public Battery(string model, int? hoursTalk, int? idleTime)
        {
            this.model = model;
            this.hoursTalk = hoursTalk;
            this.idleTime = idleTime;
        }
        public Battery(string model) : this(model, null,null)
        {
        }
        public Battery() 
        {
            this.model = null;
            this.hoursTalk = null;
            this.idleTime = null;
            this.batteryTypes = BatteryTypes.LiIon;
        }
        public override string ToString()
        {
            return string.Format("Model: {0}, Hours talk: {1}, Idle Time: {2}.", model, hoursTalk, idleTime);
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int? HourTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        public int? IdleTime
        {
            get
            {
                return this.idleTime;
            }
            set
            {
                this.idleTime = value;
            }
        }


    }
}
