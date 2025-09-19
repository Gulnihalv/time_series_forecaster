using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class ModelMetricRepository : IModelMetricRepository
{
    private readonly AppDbContext _context;
    public ModelMetricRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateMetric(ModelMetric metric)
    {
        throw new NotImplementedException();
    }

    public Task CreateMetricsAsync(IEnumerable<ModelMetric> metrics)
    {
        throw new NotImplementedException();
    }

    public Task<Dictionary<string, decimal>> GetAllMetricsForModelAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public Task<ModelMetric?> GetLatestMetricForModelAsync(int modelId, string metricName)
    {
        throw new NotImplementedException();
    }

    public Task<ModelMetric?> GetMetricByIdAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ModelMetric>> GetMetricsByNameAsync(string metricName, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ModelMetric>> GetMetricsForComparisonAsync(IEnumerable<int> modelIds, string metricName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ModelMetric>> GetMetricsForModelAsync(int modelId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MetricExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveMetric(ModelMetric metric)
    {
        throw new NotImplementedException();
    }

    public Task RemoveMetricsForModelAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public void UpdateMetric(ModelMetric metric)
    {
        throw new NotImplementedException();
    }
}
