import styles from "../../styles/componentstyles/LocationMapList.module.css"
import Location from "../location/Location"
function LocationMapList() {
    return (
        <div className={styles.locationMapListContainer}>
            <h2 className={styles.locationMapListHeader}>Top Arrival Resturants</h2>
            <div className = {styles.listContainer}>
                <Location></Location>
                <Location></Location>
                <Location></Location>
                <Location></Location>
                <Location></Location>
                <Location></Location>
            </div>
        </div>
    )
}

export default LocationMapList