import styles from "../../styles/componentstyles/LocationMapList.module.css"
import Location from "../location/Location"
function LocationMapList(props) {
    const locationArray = props.listData
    return (
        <div className={styles.locationMapListContainer}>
            <h2 className={styles.locationMapListHeader}>Top Arrival Resturants</h2>
            <div className={styles.listContainer}>
                {locationArray?.map((location) => (
                    <Location rating={location.rating} name={location.name} imgUrl = {location.icon} lat={location.geometry.location.lat} lng = {location.geometry.location.lng}></Location>
                ))}
            </div>
        </div>
    )
}

export default LocationMapList