using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TimerUI
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(5);
            CoffeMachine coffeMachine = new CoffeMachine();
            SwaddlingTheBaby swaddlingTheBaby = new SwaddlingTheBaby(timer);
            AlarmClock ac = new AlarmClock(timer);
            coffeMachine.SubscribeToEvent(timer);
            timer.StartTimer();
            Console.ReadKey();
        }
    }
}
