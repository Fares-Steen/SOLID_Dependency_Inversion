using Library;

namespace ConsoleUI;

internal class Program
{
    private static void Main(string[] args)
    {
        IPerson owner =Factory.CreatePerson();
        owner.FirstName = "Fares";
        owner.LastName = "Steen";
        owner.Emailddress = "f.s@gmail.com";
        owner.PhoneNumber = "123-9579";


        IChore chore = Factory.CreateChore();

        chore.ChoreName = "cook lunch";
        chore.Owner = owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();
    }
}