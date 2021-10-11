using Domain.Shared;

namespace Domain.Tasks
{
    public interface ITask : IEntity
    {
        string Title { get; set; }
        bool IsDone { get; set; }
    }
}
