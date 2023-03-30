namespace Lessons.Lesson11Tasks
{
    internal class EventManager<ArgsType>
    {
        private Dictionary<IListener<ArgsType>, EventType> listeners;

        public EventManager()
        {
            listeners = new Dictionary<IListener<ArgsType>, EventType>();
        }

        public void Subscribe(IListener<ArgsType> listener, EventType eventType)
        {
            listeners.Add(listener, eventType);
        }

        public void Unsubscribe(IListener<ArgsType> listener)
        {
            listeners.Remove(listener);
        }

        public void Notify(EventType eventType, ArgsType arg)
        {
            foreach (var listener in listeners)
            {
                if (listener.Value.Equals(eventType))
                {
                    listener.Key.Update(arg);
                }
            }
        }
    }
}