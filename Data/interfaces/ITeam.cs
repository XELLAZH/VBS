using VBS.Data.Models;

namespace VBS.Data.interfaces
{
    public interface ITeam
    {
        IEnumerable<Team> GetTeams { get; }
    }
}
