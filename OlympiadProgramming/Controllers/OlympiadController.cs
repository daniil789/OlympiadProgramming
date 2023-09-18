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
    public class OlympiadController : ControllerBase
    {
        private readonly IOlympiadService _olympiadService;
        private readonly IMapper _mapper;
        public OlympiadController(IOlympiadService olympiadService, IMapper mapper)
        {
            _mapper = mapper;
            _olympiadService = olympiadService;
        }

        [HttpPost("SignTeamToOlympiad")]
        public IActionResult SignTeamToOlympiad(CreateTeamToOlympiadLinkRequest request)
        {
            var linkDto = _mapper.Map<CreateTeamToOlympiadLinkDto>(request);

            var isSuccess = _olympiadService.SignTeamToOlympiad(linkDto);
            return Ok(isSuccess ? "Команда записана на олимпиаду" : "Команда уже записана на олимпиаду");
        }
    }
}
