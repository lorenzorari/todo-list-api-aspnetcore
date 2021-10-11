using System.Collections.Generic;

namespace Domain.Tasks
{
    public interface ITaskRepository
    {
        IEnumerable<ITask> GetTasks();
        ITask Create(ITask task);
        bool Update(int id, ITask task);
        bool Delete(int id);
    }
}
