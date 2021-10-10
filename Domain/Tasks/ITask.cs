﻿using Domain.Shared;

namespace Domain.Tasks
{
    interface ITask : IEntity
    {
        string Title { get; set; }
        bool IsDone { get; set; }
    }
}
