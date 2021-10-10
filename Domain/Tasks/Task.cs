namespace Domain.Tasks
{
    class Task : ITask
    {
        public string title { get; set; }
        public bool isDone { get; set; }
        public int Id { get; set; }

        public Task() { }
    }
}
