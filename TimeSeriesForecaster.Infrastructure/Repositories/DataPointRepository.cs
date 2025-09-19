using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class DataPointRepository : IDataPointRepository
{
    private readonly AppDbContext _context;

    public DataPointRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateDataPoint(DataPoint dataPoint)
    {
        throw new NotImplementedException();
    }

    public Task CreateDataPointsBulkAsync(IEnumerable<DataPoint> dataPoints)
    {
        throw new NotImplementedException();
    }

    public Task<DataPoint?> GetDataPointByIdAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DataPoint>> GetDataPointsAsync(int datasetId, DateTime? startDate = null, DateTime? endDate = null, int? limit = null)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetDataPointsCountAsync(int datasetId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DataPoint>> GetDataPointsPagedAsync(int datasetId, int page, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<(DateTime minDate, DateTime maxDate)> GetDateRangeAsync(int datasetId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DataPoint>> GetOutliersAsync(int datasetId)
    {
        throw new NotImplementedException();
    }

    public Task<(decimal minValue, decimal maxValue)> GetValueRangeAsync(int datasetId)
    {
        throw new NotImplementedException();
    }

    public void RemoveDataPoint(DataPoint dataPoint)
    {
        throw new NotImplementedException();
    }

    public Task RemoveDatapointsForDatasetAsync(int datasetId)
    {
        throw new NotImplementedException();
    }

    public void UpdateDataPoint(DataPoint dataPoint)
    {
        throw new NotImplementedException();
    }
}
