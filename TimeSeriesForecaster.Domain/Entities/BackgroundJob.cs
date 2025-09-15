namespace TimeSeriesForecaster.Domain.Entities;

public class BackgroundJob
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; } // Navigation property
    public int ProjectId { get; set; }
    public Project? Project { get; set; } // Navigation property
    public string? JobType { get; set; }
    public string? JobData { get; set; }
    public string? Status { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public int Progress { get; set; }
}
