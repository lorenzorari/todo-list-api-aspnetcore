using Domain.Tasks;
using Infrastructure.SqlServer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository = new TaskRepository();

        [HttpGet]
        public ActionResult<IEnumerable<ITask>> GetTasks()
        {
            return Ok(_taskRepository.GetTasks());
        }

        [HttpPost]
        public ActionResult<ITask> Create([FromBody] Task task)
        {
            return Ok(_taskRepository.Create(task));
        }
    }
}
