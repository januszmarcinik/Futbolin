using Microsoft.AspNetCore.Mvc;
using Futbolin.Infrastructure.Services.Football.Leagues;
using System.Threading.Tasks;

namespace Futbolin.WebAPI.Areas.Football.Controllers
{
    [Route("api/leagues")]
    public class LeaguesController : Controller
    {
        private readonly ILeagueService _leagueService;

        public LeaguesController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _leagueService.ReadAsync());
        }
    }
}