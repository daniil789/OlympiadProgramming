using AutoMapper;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.DAL.Interfaces;

namespace OlympiadProgramming.BLL.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper) 
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public TaskDto GetTask(int id)
        {
            var taskDal = _taskRepository.GetTask(id);

            var taskDto = _mapper.Map<TaskDto>(taskDal);
            return taskDto;
        }
    }
}
