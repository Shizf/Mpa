using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Mpa.Tasks.Dto;

namespace Mpa.Tasks
{
    public interface ITaskService : IApplicationService
    {
        List<Task> GetTasks();
        void UpdateTask(UpdateTaskInput input);
        void CreateTask(CreateTaskInput input);
        GetTasksInput GetTaskById(int id);
    }
}
