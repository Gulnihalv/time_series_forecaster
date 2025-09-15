using TimeSeriesForecaster.Domain.Entities;

namespace TimeSeriesForecaster.Application.Interfaces;

public interface IDatasetRepository
{
    Task<IEnumerable<Dataset>> GetAllAsync(); // Burası sonrasında düzenlenecek.
}
