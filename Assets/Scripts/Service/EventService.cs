public class EventService
{
    private static EventService instance;
    public EventService Instance 
    {
        get
        {
            if(instance == null)
                instance = new EventService();
            return instance;
        }
    }

    public EventController OnLightSwitchToggled { get; private set; }
    public EventService()
    {
        OnLightSwitchToggled = new EventController();
    }
}
