using Domain.Tasks;
using System.Collections.Generic;
using System.Data;

namespace Infrastructure.SqlServer
{
    public class TaskRepository : ITaskRepository
    {
        private ITaskFactory _taskFactory = new TaskFactory();

        public IEnumerable<ITask> GetTasks()
        {
            IList<ITask> tasks = new List<ITask>();
            
            using (var sqlConnection = Database.GetConnection())
            {
                sqlConnection.Open();
                var command = sqlConnection.CreateCommand();
                command.CommandText = TasksRequests.ReqGetTasks;

                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    tasks.Add(_taskFactory.CreateFromReader(reader));
                }
            }

            return tasks;
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
