using Microsoft.AspNetCore.Mvc;
using Futbolin.Infrastructure.Services.Football.Leagues;
using System.Threading.Tasks;

namespace Futbolin.WebAPI.Areas.Football.Controllers
{
    [Route("api/leagues")]
    public class LeaguesController : Controller
    {
        private readonly ILeaguesService _leaguesRepository;

        public LeaguesController(ILeaguesService leaguesService)
        {
            _leaguesRepository = leaguesService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var leagues = await _leaguesRepository.ReadAsync();
            if (leagues == null)
            {
                return NotFound();
            }

            return Ok(leagues);
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var league = await _leaguesRepository.ReadAsync(name);
            if (league == null)
            {
                return NotFound();
            }

            return Ok(league);
        }
    }
}