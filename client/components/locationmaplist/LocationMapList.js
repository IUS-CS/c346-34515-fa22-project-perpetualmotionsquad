import styles from "../../styles/componentstyles/LocationMapList.module.css"
import Location from "../location/Location"
function LocationMapList(props) {
    const locationArray = props.listData
    return (
        <div className={styles.locationMapListContainer}>
            <h2 className={styles.locationMapListHeader}>Top Arrival {props.listTitle}</h2>
            <div className={styles.listContainer}>
                {locationArray?.map((location) => (
                    <Location rating={location.rating} name={location.name} imgUrl = {location.icon} lat={location.geometry.location.lat} lng = {location.geometry.location.lng}></Location>
                ))}
                {locationArray?.length == 0 ?<h3 style={{ color: 'white'}}>No {props.listTitle}  Found</h3>:null}
            </div>
        </div>
    )
}

export default LocationMapList