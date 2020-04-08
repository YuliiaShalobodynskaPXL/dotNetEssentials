using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace oef_10._8_wekker
{
    public class AlarmClock
    {
        private DateTime AlarmTime;
        private int _beepTimeInSeconds;

        private string CurrentTime
        {
            get =>  $"{DateTime.Now:T}";
        }

        
        //private DateTime AlarmTime(int hour,int minute) {
        //    _alarmTime = new DateTime(hour, minute);
        //}          // set??

        public AlarmClock(int hours, int minutes, int seconds = 0)
        {  
            _beepTimeInSeconds = 10;
            AlarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, seconds);
        }

        public bool isAlarmPassed(DateTime alarmTime)
        {
            if (AlarmTime > DateTime.Now) {
                return true;
            } else return false;
            
        }

        public bool ShouldStopBeeping()
        {
            if ((AlarmTime.AddSeconds(_beepTimeInSeconds)) >= DateTime.Now)
            {   
                return true;
            } else return false;
        }

        public void Reset()
        {
            AlarmTime = DateTime.MinValue;
        }
        



        //private string currentTime;

        //public AlarmClock(DateTime alarmTime) {
        //    //DateTime dateTime = new DateTime;
        //    //var alarmTime = dateTime; 
        //}

        //public void alarm_on(DateTime alarmTime) { 
            
        //    if (DateTime.Now == alarmTime){
        //        MessageBox.Show("Wake up!");
        //    }
        //}

    }
}
