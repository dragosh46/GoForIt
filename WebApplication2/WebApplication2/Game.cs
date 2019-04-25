using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        string Location;
        DateTime DateAndHour;
        string GameType;

        public Game(int gameId,string name,string location,DateTime dateAndHour,string gameType)
        {
            Players = new List<Player>();
            GameId = gameId;
            Name = name;
            Location = location;
            DateAndHour = dateAndHour;
            GameType = gameType;
        }

        public Player GetPlayer(int playerId)
        {
            var getPlayer = Players.Find(p => p.PlayerId == playerId);
            return getPlayer;
        }
        public Game()
        {

        }
    }
}
