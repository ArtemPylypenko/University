using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer_Alarm
{
    public class Alarm
    {

        public int Id;
        public int Hours;
        public int Minutes;
        private static int idCount=0;
        public bool isActive;
        public Alarm(int h,int m)
        {
            this.Id = idCount++;
            this.Hours = h;
            this.Minutes = m;
            this.isActive = false;
        }
        
    }
}
