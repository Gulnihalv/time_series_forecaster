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

    public async Task<IEnumerable<Project>> GetAllProjectsForUserAsync(int userId, bool trackChanges)
    {
        return await _context.Projects
            .Where(p => p.UserId == userId)
            .ToListAsync();
    }

    public void CreateProject(Project project) => _context.Projects.Add(project);

    public void RemoveProject(Project project) => _context.Projects.Remove(project);

}
