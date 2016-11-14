namespace Task1
{
    public interface IEventTimer
    {
        /// <summary>
        /// Interface for subscribe / unsubscribe
        /// </summary>
        /// <param name="timer">Timer</param>

        void SubscribeToEvent(Timer timer);
        void UnSubscribeToEvent(Timer timer);
    }
}