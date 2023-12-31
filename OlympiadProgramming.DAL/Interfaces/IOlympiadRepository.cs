﻿using OlympiadProgramming.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.DAL.Interfaces
{
    public interface IOlympiadRepository
    {
        void SingTeamToOlympiad(TeamToOlympiadLink link);

        List<TeamToOlympiadLink> GetAll();
    }
}
