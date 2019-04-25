using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Notification.SmsNotification;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
  
    public class PlayerController : Controller
    {
        Game gamePlayer = new Game();
        // GET api/values/5
        [HttpGet("{id}")]
            public ActionResult<Player> Get(int playerId)
            {
            TwilioSmsNotification twil = new TwilioSmsNotification();
            twil.SendSms("+40761559101");
            var returnedPlayer = gamePlayer.GetPlayer(playerId);
           
                return returnedPlayer;
            }
        
        [HttpPost]
            public void Post([FromBody] string firstName,string lastName,int age,string mobileNumber, int gameId)
            {
            
                Player player = new Player(firstName, lastName, age, mobileNumber, gameId);
            gamePlayer.Players.Add(player);
            }
        }
}
