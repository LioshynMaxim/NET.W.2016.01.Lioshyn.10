using System;
using System.Threading;

namespace Task1
{
    public class TimerInfo : EventArgs
    {
        /// <summary>
        /// Represents an instant in time, typically expressed as a date and time of day.
        /// </summary>
        public DateTime Dt { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="dt">Represents an instant in time</param>

        public TimerInfo(DateTime dt)
        {
            if (dt == default(DateTime))
                throw new ArgumentException();
            Dt = dt;
        }
        
    }

    public class Timer
    {

        /// <summary>
        /// Time to end period
        /// </summary>

        private int countTimerDown = 0;

        /// <summary>
        /// Delegate represents the method that will handle an event when the event provides data.
        /// </summary>

        public event EventHandler<TimerInfo> Alarm = delegate { };

        #region .ctor

        /// <summary>
        /// .ctor
        /// </summary>

        public Timer()
        {
        }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="miliSeconds">Seconds for timer</param>

        public Timer(int miliSeconds)
        {
            if (miliSeconds > 0)
            {
                countTimerDown = miliSeconds * 1000;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        #endregion

        #region Alarm function

        /// <summary>
        /// Event on alarm
        /// </summary>
        /// <param name="timerInfo">An object that contains the event data.</param>

        private void OnAlarm(TimerInfo timerInfo)
        {
            EventHandler<TimerInfo> eventHandler = Alarm;

            if (eventHandler != null)
            {
                Alarm(this, timerInfo);
            }
        }

        #endregion

        #region Function for work timer

        /// <summary>
        /// Set time for timer
        /// </summary>
        /// <param name="miliSecond">Seconds for timer</param>

        public void SetTime(int miliSecond)
        {
            if (miliSecond > 0)
                countTimerDown = miliSecond * 1000;
        }

        /// <summary>
        /// Function for starting timer
        /// </summary>

        public void StartTimer()
        {
            if (countTimerDown > 0)
            {
                TimerInfo timerInfo = new TimerInfo(DateTime.Now);
                Thread.Sleep(countTimerDown);
                OnAlarm(timerInfo);
                ResetTimer();
            }
        }

        /// <summary>
        /// Reset timer
        /// </summary>

        public void ResetTimer()
        {
            countTimerDown = 0;
        }

        #endregion
    }
}
