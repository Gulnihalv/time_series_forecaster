using TimeSeriesForecaster.Domain.Entities;

namespace TimeSeriesForecaster.Application.Interfaces;

public interface IProjectRepository
{
    Task<Project?> GetProjectByIdAsync(int id, bool trackChanges);
    Task<IEnumerable<Project>> GetAllProjectsForUserAsync(int userId, bool trackChanges);
    void CreateProject(Project project);
    void RemoveProject(Project project);
}
