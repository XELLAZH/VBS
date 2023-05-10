using Microsoft.AspNetCore.Mvc;
using VBS.Data.interfaces;
using VBS.Data.Models;

namespace VBS.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayer _players;
        private readonly ITeam _team;

        public PlayersController(IPlayer players, ITeam team)
        {
            _players = players;
            _team = team;
        }

        public ViewResult PlayersList()
        {
            IEnumerable<Player> players = _players.GetAllPlayers;
            return View(players);
        }
    }
}
