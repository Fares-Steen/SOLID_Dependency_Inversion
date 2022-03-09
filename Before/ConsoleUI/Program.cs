using Library;

namespace ConsoleUI;

internal class Program
{
    private static void Main(string[] args)
    {
        Person owner = new Person
        {
            FirstName = "Fares",
            LastName = "Steen",
            Emailddress = "f.s@gmail.com",
            PhoneNumber = "123-9579"
        };

        Chore chore = new Chore
        {
            ChoreName = "cook lunch",
            Owner = owner,
        };
        
        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();
    }
}