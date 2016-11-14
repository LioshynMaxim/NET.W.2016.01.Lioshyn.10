namespace Task1
{
    public interface IEventTimer
    {
        void SubscribeToEvent(Timer timer);
        void UnSubscribeToEvent(Timer timer);
    }
}