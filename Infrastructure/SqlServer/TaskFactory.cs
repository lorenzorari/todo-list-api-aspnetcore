using Domain.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.SqlServer
{
    class TaskFactory : ITaskFactory
    {
        public ITask CreateFromReader(SqlDataReader reader)
        {
            return new Task
            {
                Id = reader.GetInt32(reader.GetOrdinal(TasksRequests.ColumnId)),
                Title = reader.GetString(reader.GetOrdinal(TasksRequests.ColumnTitle)),
                IsDone = reader.GetBoolean(reader.GetOrdinal(TasksRequests.ColumnIsDone))
            };
        }
    }
}
