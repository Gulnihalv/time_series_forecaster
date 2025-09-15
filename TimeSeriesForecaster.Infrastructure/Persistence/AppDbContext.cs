using Microsoft.EntityFrameworkCore;
using TimeSeriesForecaster.Domain.Entities;

namespace TimeSeriesForecaster.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Dataset> Datasets { get; set; }
    public DbSet<DataPoint> DataPoints { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Prediction> Predictions { get; set; }
    public DbSet<ModelMetric> ModelMetrics { get; set; }
    public DbSet<BackgroundJob> BackgroundJobs { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
