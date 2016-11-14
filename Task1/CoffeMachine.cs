using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CoffeMachine : IEventTimer
    {
        #region .ctor

        /// <summary>
        /// .ctor
        /// </summary>

        public CoffeMachine()
        {
        }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="timer">Timer</param>

        public CoffeMachine(Timer timer)
        {
            if(timer != null) 
                SubscribeToEvent(timer);
        }

        #endregion

        #region Subscribe / unsubscribe

        /// <summary>
        /// Subscribe to event
        /// </summary>
        /// <param name="timer">Timer</param>

        public void SubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventCoffeMachine;
        }

        /// <summary>
        /// Unsubscribe to event
        /// </summary>
        /// <param name="timer">Timer</param>

        public void UnSubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventCoffeMachine;
        }

        #endregion

        #region Event

        /// <summary>
        /// Event on alarm clock
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="timerInfo">An object that contains the event data.</param>

        private void EventCoffeMachine(object sender, TimerInfo timerInfo)
        {
            Console.WriteLine("Time to coffe!");
        } 

        #endregion
    }
}
