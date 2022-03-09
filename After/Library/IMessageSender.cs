namespace Library;

public interface IMessageSender
{
    void SendMessage(IPerson owner, string message);
}