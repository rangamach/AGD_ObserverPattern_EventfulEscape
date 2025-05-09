using System;

public class EventController
{
    public Action base_event;

    public void AddListener(Action listener) => base_event += listener;
    public void RemoveListener(Action listener) => base_event -= listener;
    public void InvokeEvent() => base_event?.Invoke();
}