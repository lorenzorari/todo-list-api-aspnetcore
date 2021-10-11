namespace Infrastructure.SqlServer
{
    public class TasksRequests
    {
        public static readonly string TableName = "tasks";
        public static readonly string ColumnId = "id";
        public static readonly string ColumnTitle = "title";
        public static readonly string ColumnIsDone = "is_done";

        public static readonly string ReqGetTasks = $"SELECT * FROM {TableName}";

        public static readonly string ReqCreate = $@"
            INSERT INTO {TableName} ({ColumnTitle}, {ColumnIsDone})
            OUTPUT INSERTED.{ColumnId}
            VALUES (@{ColumnTitle}, @{ColumnIsDone})
        ";

        public static readonly string ReqDelete = $@"
            DELETE FROM {TableName} WHERE {ColumnId} = @{ColumnId}
        ";

        public static readonly string ReqUpdate = $@"
            UPDATE {TableName}
            SET {ColumnTitle}  = @{ColumnTitle},
                {ColumnIsDone} = @{ColumnIsDone}
            WHERE {ColumnId} = @{ColumnId}
        ";
    }
}
