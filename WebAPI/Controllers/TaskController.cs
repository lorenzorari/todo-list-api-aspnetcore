using Domain.Tasks;
using Infrastructure.SqlServer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            return Ok(_taskRepository.GetTasks().Cast<Task>());
        }

        [HttpPost]
        public ActionResult<ITask> Create([FromBody] Task task)
        {
            return Ok(_taskRepository.Create(task));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {
            if (_taskRepository.Delete(id)) return Ok();

            return NotFound();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update(int id, [FromBody] Task task)
        {
            if (_taskRepository.Update(id, task)) return Ok();

            return NotFound();
        }
    }
}
