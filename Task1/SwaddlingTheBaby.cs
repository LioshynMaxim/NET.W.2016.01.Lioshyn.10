using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SwaddlingTheBaby : IEventTimer
    {
        #region .ctor

        /// <summary>
        /// .ctor
        /// </summary>

        public SwaddlingTheBaby()
        {
        }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="timer">Timer</param>

        public SwaddlingTheBaby(Timer timer)
        {
            if (timer != null)
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
            timer.Alarm += EventSwaddlingTheBaby;
        }

        /// <summary>
        /// Unsubscribe to event
        /// </summary>
        /// <param name="timer">Timer</param>

        public void UnSubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentException();
            timer.Alarm += EventSwaddlingTheBaby;
        }

        #endregion

        /// <summary>
        /// Event on alarm clock
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="timerInfo">An object that contains the event data.</param>

        private void EventSwaddlingTheBaby(object sender, TimerInfo timerInfo)
        {
            Console.WriteLine("Swaddling the baby!");
        }
    }
}
