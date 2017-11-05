using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Futbolin.Core.Settings;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System;

namespace Futbolin.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly GeneralSettings _generalSettings;
        private readonly ILogger _logger;

        public ValuesController(IOptions<GeneralSettings> generalSettings, ILogger logger)
        {
            _generalSettings = generalSettings.Value;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("Moderator")]
        [Authorize(Roles = "Moderator")]
        public string Moderator()
        {
            return "Moderator";
        }

        [Route("Ankieter")]
        [Authorize(Roles = "Ankieter")]
        public string Ankieter()
        {
            return "Ankieter";
        }

        [HttpGet]
        [Route("LogTest")]
        public IActionResult LogTest(string text)
        {
            _logger.LogCritical($"Critial: {text}");
            _logger.LogDebug($"Debug: {text}");
            _logger.LogError(new Exception("Jakiś tam błąd"), text);
            _logger.LogInformation($"Information: {text}");
            _logger.LogTrace($"Trace: {text}");
            _logger.LogWarning($"Warning: {text}");

            return Ok();
        }

        // GET api/values/author
        [Route("author")]
        [HttpGet]
        public string Author()
        {
            return _generalSettings.Author;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
