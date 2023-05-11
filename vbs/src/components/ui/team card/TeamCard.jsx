import PlayerLine from "./PlayerLine";

function TeamCard(){
    return (
        <div className="team-card">
            <div className="name"></div>
            <div className="players-list">
                Список игроков:
                <PlayerLine />
            </div>
        </div>
    )
}

export default TeamCard;