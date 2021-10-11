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
            using (var sqlConnection = Database.GetConnection())
            {
                sqlConnection.Open();
                var command = sqlConnection.CreateCommand();
                command.CommandText = TasksRequests.ReqCreate;

                command.Parameters.AddWithValue($"@{TasksRequests.ColumnTitle}", task.Title);
                command.Parameters.AddWithValue($"@{TasksRequests.ColumnIsDone}", task.IsDone);

                task.Id = (int) command.ExecuteScalar();
            }

            return task;
        }

        public bool Delete(int id)
        {
            using var sqlConnection = Database.GetConnection();
            sqlConnection.Open();

            var command = sqlConnection.CreateCommand();
            command.CommandText = TasksRequests.ReqDelete;
            command.Parameters.AddWithValue($"@{TasksRequests.ColumnId}", id);

            return 0 < command.ExecuteNonQuery();
        }

        public bool Update(int id, ITask task)
        {
            using var sqlConnection = Database.GetConnection();
            sqlConnection.Open();

            var command = sqlConnection.CreateCommand();
            command.CommandText = TasksRequests.ReqUpdate;

            command.Parameters.AddWithValue($"@{TasksRequests.ColumnId}", id);
            command.Parameters.AddWithValue($"@{TasksRequests.ColumnTitle}", task.Title);
            command.Parameters.AddWithValue($"@{TasksRequests.ColumnIsDone}", task.IsDone);

            return 0 < command.ExecuteNonQuery();
        }
    }
}
