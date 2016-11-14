using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CoffeMachine : IEventTimer
    {

        public CoffeMachine()
        {
        }

        public CoffeMachine(Timer timer)
        {
            if(timer != null) 
                SubscribeToEvent(timer);
        }

        public void SubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventCoffeMachine;
        }

        public void UnSubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventCoffeMachine;
        }

        private void EventCoffeMachine(object sender, TimerInfo timerInfo)
        {
            Console.WriteLine("Time to coffe!");
        }
    }
}
