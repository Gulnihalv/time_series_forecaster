using TimeSeriesForecaster.Domain.Entities;

namespace TimeSeriesForecaster.Application.Interfaces;

public interface IModelRepository
{
    Task<Model?> GetModelByIdAsync(int id, bool trackChanges);
    Task<IEnumerable<Model>> GetModelsForProjectAsync(int projectId, bool trackChanges);
    Task<IEnumerable<Model>> GetModelsForDatasetAsync(int datasetId, bool trackChanges);
    Task<IEnumerable<Model>> GetModelsByStatusAsync(string status, bool trackChanges);
    Task<Model?> GetActiveModelForDatasetAsync(int datasetId, bool trackChanges);
    Task<Model?> GetModelWithPredictionsAsync(int id, bool trackChanges);
    Task<Model?> GetModelWithMetricsAsync(int id, bool trackChanges);
    void CreateModel(Model model);
    void RemoveModel(Model model);
    void UpdateModel(Model model);
    Task<bool> ModelExistsAsync(int id);
    Task<bool> UserOwnsModelAsync(int modelId, int userId);
    Task<IEnumerable<Model>> GetCompletedModelsForDatasetAsync(int datasetId);
}
