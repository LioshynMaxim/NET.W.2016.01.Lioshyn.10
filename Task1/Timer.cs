using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class TimerInfo : EventArgs
    {
        public DateTime Dt { get; }

        public TimerInfo(DateTime dt)
        {
            if (dt == default(DateTime))
                throw new ArgumentException();
            Dt = dt;
        }
        
    }

    public class Timer
    {
        private int countTimerDown = 0;

        public event EventHandler<TimerInfo> Alarm = delegate { };

        public Timer()
        {
        }

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

        private void OnAlarm(TimerInfo e)
        {
            EventHandler<TimerInfo> eventHandler = Alarm;

            if (eventHandler != null)
            {
                Alarm(this, e);
            }
        }

        public void SetTime(int miliSecond)
        {
            if (miliSecond > 0)
                countTimerDown = miliSecond * 1000;
        }

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

        public void ResetTimer()
        {
            countTimerDown = 0;
        }
    }
}
