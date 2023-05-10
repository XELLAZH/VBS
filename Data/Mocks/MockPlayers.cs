using VBS.Data.interfaces;
using VBS.Data.Models;

namespace VBS.Data.Mocks
{
    public class MockPlayers : IPlayer
    {
        private readonly ITeam _team = new MockTeam();

        public IEnumerable<Player> GetAllPlayers {
            get
            {
                return new List<Player>
                {
                    new Player
                    {
                        FirstName = "Максим",
                        LastName = "Ковалёв",
                        Position = "OH",
                        PlayerNumber = 11,
                        IsCapitan = false,
                        TeamId = _team.GetTeams.First().Id,
                    },
                    new Player
                    {
                        FirstName = "Александр",
                        LastName = "Жучков",
                        Position = "L",
                        PlayerNumber = 27,
                        IsCapitan = false,
                        TeamId = _team.GetTeams.First().Id,
                    },
                    new Player
                    {
                        FirstName = "2",
                        LastName = "Игрок",
                        Position = "WS",
                        PlayerNumber = 2,
                        IsCapitan = false,
                        TeamId = _team.GetTeams.Last().Id
                    },
                    new Player
                    {
                        FirstName = "Илья",
                        LastName = "Дербицкий",
                        Position = "S",
                        PlayerNumber = 9,
                        IsCapitan = true,
                        TeamId = _team.GetTeams.First().Id,
                    },
                    new Player
                    {
                        FirstName = "1",
                        LastName = "Игрок",
                        Position = "S",
                        PlayerNumber = 1,
                        IsCapitan = true,
                        TeamId = _team.GetTeams.Last().Id
                    }
                };
            }
        }

        public Player GetObjectPlayer(int playerId) => throw new NotImplementedException();
    }
}
