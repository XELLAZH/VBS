import PlayerLine from "./PlayerLine";
import styles from './Team.module.css';
import {players} from '../../../data/players.data.js';

function TeamCard(){
    return (
        <div className={styles.card}>
            <div className={styles.name}>Энергия</div>
            <div className={styles.playersList}>
                Список игроков:

                {players.map(player => (
                    <PlayerLine key={player.id} player={player}/>
                ))}
            </div>
        </div>
    )
}

export default TeamCard;