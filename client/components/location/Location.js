import styles from "../../styles/componentstyles/Location.module.css"
function Location(props) {
    return (
        <div className={styles.locationContainer}>
            <div className={styles.iconRatingContainer}>
            <img className={styles.icon} src={props.imgUrl}></img>
            <h4>{props.rating}</h4>
            </div>
            <p>{props.name}</p>
        </div>)
}
export default Location