using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.Web.Models.Requests;

namespace OlympiadProgramming.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;

        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }

        [HttpPost("CreateTeam")]
        public IActionResult CreateTeam(CreateTeamRequest request)
        {
            try
            {
                var teamDto = _mapper.Map<TeamDto>(request);
                _teamService.CreateTeam(teamDto);

                return Ok("Команда успешно создана");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetTeams")]
        public IActionResult GetTeams()
        {
            return Ok(_teamService.GetTeams());
        }
    }
}
