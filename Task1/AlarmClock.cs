using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AlarmClock : IEventTimer
    {

        public AlarmClock() { }

        public AlarmClock(Timer timer)
        {
            if (timer != null)
                SubscribeToEvent(timer);
        }

        public void SubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentNullException();
            timer.Alarm += EventAlarmClock;
        }

        public void UnSubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentNullException();
            timer.Alarm -= EventAlarmClock;
        }

        private void EventAlarmClock(object sender, TimerInfo timerInfo)
        {
            TimeSpan time = DateTime.Now - timerInfo.Dt;

            Console.WriteLine("{0:D}:{1:D}:{2:D}", time.Hours, time.Minutes, time.Seconds);
        }
    }
}
