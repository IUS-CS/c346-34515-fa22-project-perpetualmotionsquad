import styles from "../../styles/componentstyles/Location.module.css"
function Location(props) {
    return (
        <a className={styles.locationContainer} href={"http://google.com/search?q=" + props.name} target="_blank">
            <div className={styles.iconRatingContainer}>
                <img className={styles.icon} src={props.imgUrl}></img>
                <h4>{props.rating}</h4>
            </div>
            <p>{props.name}</p>
        </a>)
}
export default Location