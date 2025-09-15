namespace TimeSeriesForecaster.Domain.Entities;

public class Users
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public ICollection<Projects>? Projects { get; set; } // Collection navigation property
    public ICollection<BackgroundJobs>? BackgroundJobs { get; set; } // Collection navigation property
    public bool IsAdmin { get; set; }
}
