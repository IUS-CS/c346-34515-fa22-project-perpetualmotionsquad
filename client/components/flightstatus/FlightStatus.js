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
            case "Flying":
                return (
                    <div className={styles.planeWithCircleCon}>
                        <h4 className={styles.planeStateText}>Flying</h4>
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