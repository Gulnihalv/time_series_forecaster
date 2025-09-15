namespace TimeSeriesForecaster.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public ICollection<Project>? Projects { get; set; } // Collection navigation property
    public ICollection<BackgroundJob>? BackgroundJobs { get; set; } // Collection navigation property
    public bool IsAdmin { get; set; }
}
