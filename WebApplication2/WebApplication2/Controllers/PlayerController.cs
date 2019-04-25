using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        Player player = new Player();
        // GET api/values/5
        [HttpGet("{id}")]
            public ActionResult<Player> Get(int playerId)
            {
            //SMS URILE COSTA BANI BAAA
            #region SEND SMS NOTIFICATION
            //TwilioSmsNotification twil = new TwilioSmsNotification();
            //twil.SendSms("+40761559101","ENTER BODY MESSAGE HERE");
            #endregion

            var returnedPlayer = gamePlayer.GetPlayer(playerId);
            
                return returnedPlayer;
            }
        
        [HttpPost]
            public void Post([FromBody] int playerId)            {
           
            string requestBody = Request.Body.ToString();
            Player playerDeserialized = JsonConvert.DeserializeObject<Player>(requestBody);
            string firstName=playerDeserialized.FirstName;
            string lastName = playerDeserialized.LastName;
            int age = playerDeserialized.Age;
            string mobileNumber = playerDeserialized.MobileNumber;
            int gameId = 1;
            Player player = new Player(firstName, lastName, age, mobileNumber, gameId);
            gamePlayer.Players.Add(player);
            }
        }
}
