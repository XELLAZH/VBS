using VBS.Data.interfaces;
using VBS.Data.Models;

namespace VBS.Data.Mocks
{
    public class MockTeam : ITeam
    {
        public IEnumerable<Team> GetTeams
        {
            get
            {
                return new List<Team>
                {
                    new Team(name: "Энергия"),
                    new Team(name: "CмолГУ"),
                    new Team(name: "Команда-Заглушка")
                };
            }
        }
    }
}
