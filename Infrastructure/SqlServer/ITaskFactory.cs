using Domain.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.SqlServer
{
    interface ITaskFactory
    {
        ITask CreateFromReader(SqlDataReader reader);
    }
}
