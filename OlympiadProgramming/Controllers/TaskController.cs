using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.Web.Models.Responses;

namespace OlympiadProgramming.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public TaskController(ITaskService taskService, IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTask(int id)
        {
            var taskDto = _taskService.GetTask(id);

            var response = _mapper.Map<TaskResponse>(taskDto);

            return Ok(response);

        }

    }
}
