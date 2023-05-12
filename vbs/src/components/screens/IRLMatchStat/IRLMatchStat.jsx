import TeamCard from "../../ui/team card/TeamCard";
import styles from './IRLMatchStat.module.css';

function IRLMatchStat() {
    return(
        <div className={styles.container}>
            <TeamCard/>
            <TeamCard/>
        </div>
    )
}

export default IRLMatchStat;