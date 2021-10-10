using System.Collections.Generic;

namespace Domain.Tasks
{
    interface ITaskRepository
    {
        IEnumerable<ITask> Query();
        ITask Create(ITask task);
        bool Update(int id, ITask task);
        bool Delete(int id, ITask task);
    }
}
