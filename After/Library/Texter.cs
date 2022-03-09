namespace Library;

public class Texter:IMessageSender
{
    public void SendMessage(IPerson owner, string message)
    {
        Console.WriteLine($"Simulating sending a text to {owner.PhoneNumber}");
    }
}