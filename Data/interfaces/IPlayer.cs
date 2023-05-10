using VBS.Data.Models;

namespace VBS.Data.interfaces
{
    public interface IPlayer
    {
        IEnumerable<Player> GetAllPlayers { get; }

        Player GetObjectPlayer(int playerId);
    }
}
