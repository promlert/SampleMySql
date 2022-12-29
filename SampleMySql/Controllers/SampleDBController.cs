using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SampleMySql.Models;
using System.Data;

namespace SampleMySql.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleDBController : ControllerBase
    {
        private readonly IConfiguration _conIConfiguration;
        private static readonly string[] Summaries = new[]
      {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SampleDBController> _logger;

        public SampleDBController(ILogger<SampleDBController> logger, IConfiguration conIConfiguration)
        {
            _logger = logger;
            _conIConfiguration = conIConfiguration;
        }


        [HttpGet]
        public IActionResult GetPersonDB()
        {
    
            DataTable tb = new DataTable();
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(_conIConfiguration.GetConnectionString("DefaultConnection"));
            using (MySql.Data.MySqlClient.MySqlDataAdapter dpt = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT PersonID, LastName, FirstName, Address, City FROM Persons;", mySqlConnection))
            {
                mySqlConnection.Open();
                dpt.Fill(tb);
            }
           string json = JsonConvert.SerializeObject(tb, Formatting.Indented);
            return Ok(json);
        }

        [HttpGet]
        public IActionResult GetPersonDB2()
        {

            DataTable tb = new DataTable();
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(_conIConfiguration.GetConnectionString("MysqlConnection"));
            using (MySql.Data.MySqlClient.MySqlDataAdapter dpt = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT PersonID, LastName, FirstName, Address, City FROM Persons;", mySqlConnection))
            {
                mySqlConnection.Open();
                dpt.Fill(tb);
            }
            string json = JsonConvert.SerializeObject(tb, Formatting.Indented);
            return Ok(json);
        }
    }
}
