using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.BLL.Dto
{
    public class CreateTeamToOlympiadLinkDto
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int OlympiadId { get; set; }
    }
}
