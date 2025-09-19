using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class ModelRepository: IModelRepository
{
    private readonly AppDbContext _context;
    public ModelRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateModel(Model model)
    {
        throw new NotImplementedException();
    }

    public Task<Model?> GetActiveModelForDatasetAsync(int datasetId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Model>> GetCompletedModelsForDatasetAsync(int datasetId)
    {
        throw new NotImplementedException();
    }

    public Task<Model?> GetModelByIdAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Model>> GetModelsByStatusAsync(string status, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Model>> GetModelsForDatasetAsync(int datasetId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Model>> GetModelsForProjectAsync(int projectId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<Model?> GetModelWithMetricsAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<Model?> GetModelWithPredictionsAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ModelExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveModel(Model model)
    {
        throw new NotImplementedException();
    }

    public void UpdateModel(Model model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserOwnsModelAsync(int modelId, int userId)
    {
        throw new NotImplementedException();
    }
}
