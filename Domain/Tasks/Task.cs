namespace Domain.Tasks
{
    class Task : ITask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public Task() { }
    }
}
