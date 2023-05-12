import styles from './Player.module.css';


function PlayerLine({player}) {
    if (player.isCapitan) {
        return (
            <div className={styles.capitanLine}>
                <div className={styles.fullname}>{`${player.lastName} ${player.firstName[0]}.`}</div>
                <div className={styles.position}>{player.position}</div>
                <div className={styles.playerNumber}>{player.playerNumber}</div>
            </div>
        )
    }
    else {
        return (
            <div className={styles.playerLine}>
                <div className={styles.fullname}>{`${player.lastName} ${player.firstName[0]}.`}</div>
                <div className={styles.position}>{player.position}</div>
                <div className={styles.playerNumber}>{player.playerNumber}</div>
            </div>
        )
    }
};

export default PlayerLine;