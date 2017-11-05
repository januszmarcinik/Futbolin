using Microsoft.AspNetCore.Mvc;
using Futbolin.Infrastructure.Services.Football.Leagues;
using System.Threading.Tasks;
using Futbolin.Infrastructure.DTO.Football;
using System;

namespace Futbolin.WebAPI.Areas.Football.Controllers
{
    [Route("api/leagues")]
    public class LeaguesController : Controller
    {
        private readonly ILeaguesService _leaguesService;

        public LeaguesController(ILeaguesService leaguesService)
        {
            _leaguesService = leaguesService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var leagues = await _leaguesService.ReadAsync();
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
            var league = await _leaguesService.ReadAsync(name);
            if (league == null)
            {
                return NotFound();
            }

            return Ok(league);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Post([FromBody]LeagueDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _leaguesService.CreateAsync(model);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPut]
        [Route("update/{name}")]
        public async Task<IActionResult> Put(string name, [FromBody]LeagueDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _leaguesService.UpdateAsync(name, model);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]
        [Route("delete/{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            try
            {
                await _leaguesService.DeleteAsync(name);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
