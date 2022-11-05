import styles from "../../styles/componentstyles/FlightData.module.css"

function FlightData() {
    return (
        <div className={styles.flightDataContainer}>
            <div className={styles.dataContainer}>
                <div className={styles.textContainer}>
                    <h2>Departing From:</h2>
                    <p>Dallas Fort Worth</p>
                </div>
                <div className = {styles.textContainer}>
                    <h2>Arriving At:</h2>
                    <p>Harrisburg</p>
                </div>
                <div className = {styles.textContainer}>
                    <h2>Distance:</h2>
                    <p>1230.791 Miles</p>
                </div>
                <div className={styles.textContainer}>
                    <h2>Aircraft</h2>
                    <p>Airbus A319</p>
                </div>
            </div>
            <img className={styles.planeImage} src="https://farm66.staticflickr.com/65535/52301300663_edee17a549_z.jpg">
            </img>
        </div>)
}
export default FlightData