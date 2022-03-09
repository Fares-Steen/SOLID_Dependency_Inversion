namespace Library;

public class Emailer : IMessageSender
{
    public void SendMessage(IPerson owner, string message)
    {
        Console.WriteLine($"Simulating sending an emil to {owner.Emailddress}");
    }
}