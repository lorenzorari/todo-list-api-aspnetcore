namespace Domain.Tasks
{
    interface ITask
    {
        string title { get; set; }
        bool isDone { get; set; }
    }
}
