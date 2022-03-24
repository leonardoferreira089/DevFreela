using DevFreela.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task AddAsync(Project project);
        Task<List<Project>> GetAllAsync();        
        Task<Project> GetByIdAsync(int id);
        Task StartAsync(Project project);
        Task FinishAsync(Project project);
        Task SaveChangesAsync();
        Task AddCommentAsync(ProjectComment projectComment);
        Task DeleteAsync(Project project);

    }
}
