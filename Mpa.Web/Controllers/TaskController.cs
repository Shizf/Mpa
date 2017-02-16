using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mpa.Tasks;

namespace Mpa.Web.Controllers
{
    public class TaskController : MpaControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public ActionResult Index()
        {
            var output = _taskService.GetTasks();
            return View(output);
        }

    }
}