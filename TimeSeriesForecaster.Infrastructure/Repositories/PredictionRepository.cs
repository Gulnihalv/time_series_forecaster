using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class PredictionRepository : IPredictionRepository
{
    private readonly AppDbContext _context;
    public PredictionRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreatePrediction(Prediction prediction)
    {
        throw new NotImplementedException();
    }

    public Task CreatePredictionsBulkAsync(IEnumerable<Prediction> predictions)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Prediction>> GetAnomaliesForModelAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public Task<Prediction?> GetPredictionByIdAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<(DateTime minDate, DateTime maxDate)> GetPredictionDateRangeAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Prediction>> GetPredictionsByDateRangeAsync(int modelId, DateTime startDate, DateTime endDate, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetPredictionsCountAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Prediction>> GetPredictionsForModelAsync(int modelId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Prediction>> GetPredictionsPagedAsync(int modelId, int page, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Prediction>> GetPredictionsWithActualsAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public void RemovePrediction(Prediction prediction)
    {
        throw new NotImplementedException();
    }

    public Task RemovePredictionsForModelAsync(int modelId)
    {
        throw new NotImplementedException();
    }

    public void UpdatePrediction(Prediction prediction)
    {
        throw new NotImplementedException();
    }
}
