using Microsoft.EntityFrameworkCore;
using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class DatasetRepository : IDatasetRepository
{
    private readonly AppDbContext _context;

    public DatasetRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateDataset(Dataset dataset)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DatasetExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Dataset>> GetAllDatasetsForProjectAsync(int projectId, bool trackChanges, bool includeUnprocessed = true)
    {
        throw new NotImplementedException();
    }

    public Task<Dataset?> GetDatasetByIdAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<(DateTime startDate, DateTime endDate)> GetDatasetDateRangeAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetDatasetRecordCountAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsDatasetProcessedAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveDataset(Dataset dataset)
    {
        throw new NotImplementedException();
    }

    public void UpdateDataset(Dataset dataset)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserOwnsDatasetAsync(int datasetId, int userId)
    {
        throw new NotImplementedException();
    }
}
