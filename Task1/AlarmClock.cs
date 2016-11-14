using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AlarmClock : IEventTimer
    {
        #region .ctor

        /// <summary>
        /// .ctor
        /// </summary>

        public AlarmClock() { }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="timer">Timer</param>

        public AlarmClock(Timer timer)
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
                throw new ArgumentNullException();
            timer.Alarm += EventAlarmClock;
        }

        /// <summary>
        /// Unsubscribe to event
        /// </summary>
        /// <param name="timer">Timer</param>

        public void UnSubscribeToEvent(Timer timer)
        {
            if (timer == null)
                throw new ArgumentNullException();
            timer.Alarm -= EventAlarmClock;
        }

        #endregion

        #region Event

        /// <summary>
        /// Event on alarm clock
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="timerInfo">An object that contains the event data.</param>

        private void EventAlarmClock(object sender, TimerInfo timerInfo)
        {
            TimeSpan time = DateTime.Now - timerInfo.Dt;
            Console.WriteLine("{0:D}:{1:D}:{2:D}", time.Hours, time.Minutes, time.Seconds);
        }

        #endregion

        
    }
}
