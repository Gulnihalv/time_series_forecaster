namespace TimeSeriesForecaster.Domain.Entities;

public class Projects
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public Users? User { get; set; } // Navigation property
    public string? Name { get; set; }
    public ICollection<Datasets>? Datasets { get; set; } // Collection navigation property
    public ICollection<Models>? Models { get; set; } // Collection navigation property
    public ICollection<BackgroundJobs>? BackgroundJobs { get; set; } // Collection navigation property
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }
}
