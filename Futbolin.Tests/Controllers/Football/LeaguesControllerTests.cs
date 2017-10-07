using Futbolin.Infrastructure.DTO.Football;
using Futbolin.WebAPI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Futbolin.Tests.Controllers.Football
{
    [TestClass]
    public class LeaguesControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public LeaguesControllerTests()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TestMethod]
        public async Task League_by_name_should_exist()
        {
            // Act
            var name = "Bundesliga";
            var response = await _client.GetAsync($"api/leagues/{name}");
            var content = await response.Content.ReadAsStringAsync();
            var league = JsonConvert.DeserializeObject<LeagueDTO>(content);

            // Assert
            Assert.AreEqual(league.Name, "Bundesliga");
            Assert.AreEqual(league.Country, "Niemcy");
        }

        [TestMethod]
        public async Task League_by_name_should_not_exist()
        {
            // Act
            var name = "ASDSADASDASDASDA";
            var response = await _client.GetAsync($"api/leagues/{name}");

            // Assert
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
