using OlympiadProgramming.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.BLL.Interfaces
{
    public interface ITaskService
    {
        TaskDto GetTask(int id);
    }
}
