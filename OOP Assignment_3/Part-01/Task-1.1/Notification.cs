
namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message);
}

public class EmailNotification : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}

public class WhatsAppNotification : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[whatsapp] {to}: {message}");
}

public abstract class NotificationDecorator : INotificationChannel
{
    protected readonly INotificationChannel Channel;

    protected NotificationDecorator(INotificationChannel channel)
    {
        Channel = channel;
    }

    public abstract void Send(string to, string message);
}

public class UrgentNotification : NotificationDecorator
{
    public UrgentNotification(INotificationChannel channel)
        : base(channel)
    {
    }

    public override void Send(string to, string message) =>
        Channel.Send(to, $"[URGENT] {message}");
}

public class ScheduledNotification : NotificationDecorator
{
    private readonly DateTime _sendAt;

    public ScheduledNotification(
        INotificationChannel channel,
        DateTime sendAt)
        : base(channel)
    {
        _sendAt = sendAt;
    }

    public override void Send(string to, string message) =>
        Console.WriteLine(
            $"[{_sendAt:g}] {to}: {message}");
}
