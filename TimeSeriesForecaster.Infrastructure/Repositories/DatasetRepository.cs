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

    public async Task<IEnumerable<Dataset>> GetAllAsync() // Sadece datasetleri döndürüyor
    {
        return await _context.Datasets.ToListAsync();
    }
}
