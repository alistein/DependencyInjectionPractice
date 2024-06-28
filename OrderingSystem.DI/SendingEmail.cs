namespace OrderingSystem.DI;

public class SendingEmail : ICustomerCommunication
{
    public void Send(string message)
    {
        Console.WriteLine($"{message} and Email send!");
    }
}