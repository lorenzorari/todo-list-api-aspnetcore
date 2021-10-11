using Domain.Tasks;
using System.Collections.Generic;

namespace Infrastructure.SqlServer
{
    public class TaskRepository : ITaskRepository
    {
        public IEnumerable<ITask> GetTasks()
        {
            throw new System.NotImplementedException();
        }

        public ITask Create(ITask task)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id, ITask task)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(int id, ITask task)
        {
            throw new System.NotImplementedException();
        }
    }
}
