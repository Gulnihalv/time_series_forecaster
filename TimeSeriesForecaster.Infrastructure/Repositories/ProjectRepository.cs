using Microsoft.EntityFrameworkCore;
using TimeSeriesForecaster.Application.Interfaces;
using TimeSeriesForecaster.Domain.Entities;
using TimeSeriesForecaster.Infrastructure.Persistence;

namespace TimeSeriesForecaster.Infrastructure.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly AppDbContext _context;

    public ProjectRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Project?> GetProjectByIdAsync(int id, bool trackChanges)
    {
        return await _context.Projects
            .Include(p => p.Datasets) // Eager loading yapılabilir. Yani proje yüklenirken datasetler de yükleniyor.
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Project>> GetAllProjectsForUserAsync(int userId, bool trackChanges, bool includeInactive = false)
    {
        var query = _context.Projects
            .Where(p => p.UserId == userId);

        if (!includeInactive)
        {
            query = query.Where(p => p.IsActive);
        }

        return await query.ToListAsync();
    }

    public void CreateProject(Project project) => _context.Projects.Add(project);

    public void RemoveProject(Project project) => _context.Projects.Remove(project);

    public void UpdateProject(Project project)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ProjectExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserOwnsProjectAsync(int projectId, int userId)
    {
        throw new NotImplementedException();
    }
}
