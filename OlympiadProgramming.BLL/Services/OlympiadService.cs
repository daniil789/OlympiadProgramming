using AutoMapper;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;

namespace OlympiadProgramming.BLL.Services
{
    public class OlympiadService : IOlympiadService
    {
        private readonly IOlympiadRepository _olympiadRepository;
        private readonly IMapper _mapper;

        public OlympiadService(IOlympiadRepository olympiadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _olympiadRepository = olympiadRepository;
        }

        public bool SignTeamToOlympiad(CreateTeamToOlympiadLinkDto dto)
        {
            var teamSignToOlympiad = _olympiadRepository.GetAll()
                .SingleOrDefault(l => l.TeamId == dto.TeamId && l.OlympiadId == dto.OlympiadId);

            if (teamSignToOlympiad is null)
            {
                var linkDal = _mapper.Map<TeamToOlympiadLink>(dto);
                _olympiadRepository.SingTeamToOlympiad(linkDal);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
