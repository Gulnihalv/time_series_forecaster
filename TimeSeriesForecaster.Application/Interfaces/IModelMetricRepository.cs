using TimeSeriesForecaster.Domain.Entities;

namespace TimeSeriesForecaster.Application.Interfaces;

public interface IModelMetricRepository
{
    Task<ModelMetric?> GetMetricByIdAsync(int id, bool trackChanges);
    Task<IEnumerable<ModelMetric>> GetMetricsForModelAsync(int modelId, bool trackChanges);
    Task<ModelMetric?> GetLatestMetricForModelAsync(int modelId, string metricName);
    Task<IEnumerable<ModelMetric>> GetMetricsByNameAsync(string metricName, bool trackChanges);
    void CreateMetric(ModelMetric metric);
    Task CreateMetricsAsync(IEnumerable<ModelMetric> metrics); // Bulk insert
    void RemoveMetric(ModelMetric metric);
    Task RemoveMetricsForModelAsync(int modelId);
    void UpdateMetric(ModelMetric metric);
    Task<bool> MetricExistsAsync(int id); // Belirli bir metrik var mı
    Task<Dictionary<string, decimal>> GetAllMetricsForModelAsync(int modelId); // Key-Value pairs
    Task<IEnumerable<ModelMetric>> GetMetricsForComparisonAsync(IEnumerable<int> modelIds, string metricName);
}
