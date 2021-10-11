using System.Data.SqlClient;

namespace Infrastructure
{
    class Database
    {
        private static readonly string ConnectionString =
            @"Server=LORENZUS\SQLEXPRESS;Database=todo_list_react_aspnetcore;Integrated Security=SSPI";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
