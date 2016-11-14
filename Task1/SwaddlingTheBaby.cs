using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SwaddlingTheBaby : IEventTimer
    {
        public SwaddlingTheBaby()
        {
        }

        public SwaddlingTheBaby(Timer timer)
        {
            if (timer != null)
                SubscribeToEvent(timer);
        }

        public void SubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventSwaddlingTheBaby;
        }

        public void UnSubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventSwaddlingTheBaby;
        }

        private void EventSwaddlingTheBaby(object sender, TimerInfo timerInfo)
        {
            Console.WriteLine("Swaddling the baby!");
        }
    }
}
