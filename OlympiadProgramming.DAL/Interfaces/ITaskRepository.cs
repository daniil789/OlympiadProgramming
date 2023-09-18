using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.DAL.Interfaces
{
    public interface ITaskRepository
    {
        Models.Task GetTask(int id);
    }
}
