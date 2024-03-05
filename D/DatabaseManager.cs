namespace D;

public class DatabaseManager(INotification notification)
{
    private readonly INotification _notification = notification;

    public void Create()
    {
        _notification.Send("Create Record Successfully.");
    }

    public void Read()
    {
        _notification.Send("Read Record Successfully.");
    }

    public void Update() 
    {
        _notification.Send("Update Record Successfully.");
    }

    public void Delete()
    {
        _notification.Send("Delete Record Successfully.");
    }
}
