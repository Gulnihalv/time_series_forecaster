namespace TimeSeriesForecaster.Domain.Entities;

public class Models
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public Projects? Project { get; set; } // Navigation property
    public int DatasetId { get; set; }
    public Datasets? Dataset { get; set; } // Navigation property
    public ICollection<Predictions>? Predictions { get; set; } // Collection navigation property
    public ICollection<ModelMetrics>? ModelMetrics { get; set; } // Collection navigation property
    public string? ModelName { get; set; }
    public string? ModelType { get; set; }
    public string? Algorithm { get; set; }
    public string? Hyperparameters { get; set; } // burası daha sonra jsonb olarak değişebilir.
    public string? ModelFilePath { get; set; }
    public string? Status { get; set; }
    public DateTime? TrainingStartedAt { get; set; }
    public DateTime? TrainingCompletedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
    
}
