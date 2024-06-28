namespace OrderingSystem.Traditional;

public class Ordering
{
    private SendingEmail? _sendingEmail = null;
    private SendingSms? _sendingSms = null;

    private readonly bool IsSendingSms = true;

    public void Order(string message)
    {
        if (IsSendingSms)
        {
            _sendingSms ??= new SendingSms();
            
            _sendingSms.Send(message);
        }
        else
        {
            _sendingEmail ??= new SendingEmail();
            
            _sendingEmail.Send(message);
        }
    }
}