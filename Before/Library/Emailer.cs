namespace Library;

public class Emailer
{
    public void SendEmail(Person owner, string message)
    {
        Console.WriteLine($"Simulating sending an emil to {owner.Emailddress}");
    }
}