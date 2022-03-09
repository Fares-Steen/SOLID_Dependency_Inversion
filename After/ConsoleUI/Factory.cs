using Library;

namespace ConsoleUI;

public static class Factory
{
    public static IPerson CreatePerson()
    {
        return new Person();
    }

    public static IChore CreateChore()
    {
        return new Chore(CreateLogger(),CreateMessageSender());
    }

    private static ILogger CreateLogger()
    {
        return new Logger();
    }

    private static IMessageSender CreateMessageSender()
    {
        //return new Emailer();
        return new Texter();
    }
}