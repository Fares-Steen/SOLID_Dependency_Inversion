
namespace Library;

public interface IChore
{
    string ChoreName { get; set; }
    IPerson Owner { get; set; }
    double HoursWorked { get; set; }
    bool IsComplete { get; set; }
    void PerformedWork(double hours);
    void CompleteChore();
}

public class Chore : IChore
{
    public string ChoreName { get; set; }
    public IPerson Owner { get; set; }
    public double HoursWorked { get; set; }
    public bool IsComplete { get; set; }

    private readonly ILogger _logger;
    private readonly IMessageSender _messageSender;

    public Chore(ILogger logger, IMessageSender messageSender)
    {
        _logger = logger;
        _messageSender = messageSender;
    }

    public void PerformedWork(double hours)
    {
        HoursWorked += hours;
        
        _logger.Log($"Performed work on {ChoreName}");
    }

    public void CompleteChore()
    {
        IsComplete = true;
      
        _logger.Log($"Completed {ChoreName}");

       
        _messageSender.SendMessage(Owner,$"The chore {ChoreName} is complete.");
    }
}