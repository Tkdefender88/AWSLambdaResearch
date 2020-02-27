using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Services;

namespace RestAPI.Controllers
{
    [Route("/Hello")]
    public class JohnDoeController : Controller
    {
        
        private readonly IGreetingService _greetingService;

        public JohnDoeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet]
        public IActionResult GetGreeting()
        {
            Dictionary<string, int> result = _greetingService.GetGreetings();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToGreetings([FromBody] GreetingsListModel greetings)
        {
            _greetingService.AddGreetings(greetings);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteGreeting([FromBody] GreetingsListModel greetingsList)
        {
            _greetingService.RemoveItem(greetingsList.Name);
            
            return Ok();
        }
    }
}