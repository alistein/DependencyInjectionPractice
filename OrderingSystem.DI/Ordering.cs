namespace OrderingSystem.DI;

public class Ordering(ICustomerCommunication customerCommunication)
{

    public void Order(string message)
    {
        customerCommunication.Send(message);
    }
}