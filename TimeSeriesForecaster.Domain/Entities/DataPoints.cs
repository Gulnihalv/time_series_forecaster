namespace TimeSeriesForecaster.Domain.Entities;

public class DataPoints
{
    public long Id { get; set; }
    public int DatasetId { get; set; }
    public Datasets? Dataset { get; set; } // Navigation property
    public DateTime Timestamp { get; set; }
    public decimal Value { get; set; }
    public bool IsOutlier { get; set; }
    public DateTime CreatedAt { get; set; }
}
