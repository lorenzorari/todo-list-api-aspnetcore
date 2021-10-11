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
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Title = reader.GetString(reader.GetOrdinal("title")),
                IsDone = reader.GetBoolean(reader.GetOrdinal("is_done"))
            };
        }
    }
}
