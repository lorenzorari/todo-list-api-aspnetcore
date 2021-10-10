using Domain.Shared;

namespace Domain.Tasks
{
    interface ITask : IEntity
    {
        string title { get; set; }
        bool isDone { get; set; }
    }
}
