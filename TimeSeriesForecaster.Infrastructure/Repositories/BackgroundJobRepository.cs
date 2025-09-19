using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class BackgroundJobRepository: IBackgroundJobRepository
{
    private readonly AppDbContext _context;

    public BackgroundJobRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateJob(BackgroundJob job)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BackgroundJob>> GetActiveJobsAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BackgroundJob>> GetCompletedJobsOlderThanAsync(DateTime cutoffDate)
    {
        throw new NotImplementedException();
    }

    public Task<BackgroundJob?> GetJobByIdAsync(int id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BackgroundJob>> GetJobsByStatusAsync(string status, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BackgroundJob>> GetJobsByTypeAsync(string jobType, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BackgroundJob>> GetJobsForDatasetAsync(int datasetId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BackgroundJob>> GetJobsForUserAsync(int userId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<BackgroundJob?> GetRunningJobForDatasetAsync(int datasetId, string jobType)
    {
        throw new NotImplementedException();
    }

    public Task<bool> JobExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void RemoveJob(BackgroundJob job)
    {
        throw new NotImplementedException();
    }

    public void UpdateJob(BackgroundJob job)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserOwnsJobAsync(int jobId, int userId)
    {
        throw new NotImplementedException();
    }
}
