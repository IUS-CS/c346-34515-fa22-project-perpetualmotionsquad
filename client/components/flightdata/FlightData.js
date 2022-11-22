import styles from "../../styles/componentstyles/FlightData.module.css"

function FlightData(props) {
    return (
        <div className={styles.flightDataContainer}>
            <div className={styles.dataContainer}>
                <div className={styles.textContainer}>
                    <h2>Departing From:</h2>
                    <p>{props.departureAirport}</p>
                </div>
                <div className = {styles.textContainer}>
                    <h2>Arriving At:</h2>
                    <p>{props.arrivalAirport}</p>
                </div>
                <div className = {styles.textContainer}>
                    <h2>Distance:</h2>
                    <p>{props.distance} Miles</p>
                </div>
                <div className={styles.textContainer}>
                    <h2>Aircraft</h2>
                    <p>{props.aircraft}</p>
                </div>
            </div>
            <img className={styles.planeImage} src={props.aircraftImgUrl}>
            </img>
        </div>)
}
export default FlightData