import styles from "../../styles/componentstyles/FlightStatus.module.css"
export default function FlightStatus(props) {
    const flightStatus = props.flightStatus
    
    function flightStatusLogicFirst() {
        switch (flightStatus) {
            case "Scheduled":
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Scheduled</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Unknown":
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Unknown</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Canceled":
               return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Canceled</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "CheckIn":
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Check In</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Boarding" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Boarding</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "GateClosed" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Gate Closed</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Delayed" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Delayed</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "CanceledUncertain" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Canceled</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            default:
                return (
                    <div className={styles.dotWithTextCon}>
                        <h4 className={styles.planeStateText}>Scheduled</h4>
                        <div className={styles.dot}></div>
                    </div>
                )
        }
    }
    function flightStatusLogicSecond() {
        switch (flightStatus) {
            case ("Flying"):
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Flying</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case ("Departed"):
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Flying</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)

            case "EnRoute":
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>EnRoute</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Approaching" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Approaching</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Expected" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Expected</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            case "Diverted" :
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Diverted</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            default:
                return (
                    <div className={styles.dotWithTextCon}>
                        <h4 className={styles.planeStateText}>Flying</h4>
                        <div className={styles.dot}></div>
                    </div>
                )
        }
    }
    function flightStatusLogicThird() {
        switch (flightStatus) {
            case "Arrived":
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Arrived</h4>
                        <img className={styles.plane} src="/Svgs/plane.svg" />
                        <div className={styles.dot}></div>
                    </div>)
            default:
                return (
                    <div className={styles.dotWithTextCon}>
                        <h4 className={styles.planeStateText}>Arrived</h4>
                        <div className={styles.dot}></div>
                    </div>
                )
        }
    }

    return (
        <div className={styles.flightStatusCon}>
            {flightStatusLogicFirst()}
            <div className={styles.line}></div>
            {flightStatusLogicSecond()}
            <div className={styles.line}></div>
            {flightStatusLogicThird()}
        </div>)
}