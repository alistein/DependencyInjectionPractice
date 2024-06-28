namespace OrderingSystem.IoC;

public class SendingSms : ICustomerCommunication
{
    public void Send(string message)
    {
        Console.WriteLine($"{message} and Sms sent!");
    }
}