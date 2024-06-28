namespace OrderingSystem.IoC;

public class Ordering
{
    private ICustomerCommunication? _customerCommunication = null;

    private readonly bool IsSendingSms = true;

    public void Order(string message)
    {
        if (IsSendingSms)
        {
            _customerCommunication ??= new SendingSms();
            
            _customerCommunication.Send(message);
        }
        else
        {
            _customerCommunication ??= new SendingEmail();
            
            _customerCommunication.Send(message);
        }
    }
}