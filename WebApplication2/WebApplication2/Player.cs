using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Player
    {   
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public int GameId { get; set; }

        public Player(string firstName, string lastName, int age,string mobileNumber,int gameId)
        {
            PlayerId = 1;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MobileNumber = mobileNumber;
            GameId = gameId;
        }

        public Player()
        {

        }
    }
}
