using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Mpa.Tasks.Dto;

namespace Mpa.Tasks
{
    public class TaskService : ApplicationService, ITaskService
    {
        private readonly IRepository<Task, long> _taskRepository;
        private IRepository<Person> _personRepository;
        public TaskService(IRepository<Task, long> taskRepository, IRepository<Person> personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }

        public List<Task> GetTasks()
        {
            return _taskRepository.GetAll().ToList();
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            throw new NotImplementedException();
        }

        public void CreateTask(CreateTaskInput input)
        {
            throw new NotImplementedException();
        }

        public GetTasksInput GetTaskById(int id)
        {
            return _taskRepository.Get(id).MapTo<GetTasksInput>();
        }
    }
}
