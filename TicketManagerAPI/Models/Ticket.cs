namespace TicketManagerAPI.Models;

public class Ticket
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public short Status { get; set; } // 0 = open; 1 = in progress; 2 = closed;
    public DateTime SubmitTime { get; set; }
    public DateTime UpdateTime { get; set; }

    public Ticket(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = 0;
        SubmitTime = DateTime.Now;
        UpdateTime = DateTime.Now;
    }
}