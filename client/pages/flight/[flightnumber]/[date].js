import Link from 'next/link'
import styles from "../../../styles/pagestyles/FlightPage.module.css"
import FlightService from '../../../services/FlightsService'
import MapDataService from "../../../services/MapsDataService"
import { useRouter } from 'next/router'
//Components 
import FlightStatus from '../../../components/flightstatus/FlightStatus'
import FlightData from "../../../components/flightdata/FlightData"
import LocationMapList from '../../../components/locationmaplist/LocationMapList'


function flightStatusHeaderText(status, arrivalAirport) {
    switch (status) {
        case "Scheduled":
            return <h1>Flight Is Scheduled, Get Ready To Fly</h1>
        case "Unknown":
            return <h1>Flight Status Is Unknown</h1>
        case ("Flying"):
            return <h1>Get Ready To Be In {arrivalAirport}</h1>
        case ("Departed"):
            return <h1>Get Ready To Be In {arrivalAirport}</h1>
        case "Canceled":
            return <h1>Sorry, This Flight Has Been Canceled</h1>
        case "Arrived":
            return <h1>Welcome To {arrivalAirport}</h1>
        case "EnRoute":
            return <h1>Get Ready To Be In {arrivalAirport}</h1>
        case "CheckIn":
            return <h1>Time To Check In</h1>
        case "Boarding":
            return <h1>Flight Is Boarding</h1>
        case "GateClosed":
            return <h1>Gates Just Closed</h1>
        case "Delayed":
            return <h1>Flight Is Delayed</h1>
        case "Approaching":
            return <h1>Get Ready To Be In {arrivalAirport}</h1>
        case "Expected":
            return <h1>Flight Is Expected</h1>
        case "Diverted":
            return <h1>Flight Has Diverted</h1>
        case "CanceledUncertain":
            return <h1>Flight Is Canceled But Not Certain</h1>
    }
}

export default function flight({ flightData, restaurantData, hotelData }) {
    return (
        flightData ?
            <div className={styles.flightPageContainer}>
                <div className={styles.leftPageContainer}>
                    {flightStatusHeaderText(flightData[0].status, flightData[0].arrival.airport.shortName)}
                    <FlightStatus flightStatus={flightData[0].status}></FlightStatus>
                    <FlightData arrivalAirport={flightData[0].arrival.airport.shortName} departureAirport={flightData[0].departure.airport.shortName} distance={flightData[0].greatCircleDistance.mile} aircraft={flightData[0].aircraft.model} aircraftImgUrl={flightData[0].aircraft.image?.url}></FlightData>
                </div>
                <div className={styles.rightPageContainer}>
                    <LocationMapList listTitle = "Restaurants"listData={restaurantData.results}></LocationMapList>
                    <LocationMapList listTitle = "Hotels" listData={hotelData.results}></LocationMapList>
                </div>
            </div> : <div className={styles.flightPageNotFound}><h1>Error Finding Your Flight</h1></div>)
}
export async function getServerSideProps(context) {
    const flightNumber = context.params.flightnumber
    const date = context.params.date
    let restaurantData = []
    let hotelData = []
    const flightData = await FlightService.GetFlightFromNumber(flightNumber, date)
    console.log(flightData)
    if (flightData != null) {
        restaurantData = await MapDataService.GetRestaurantsNearby(flightData[0].arrival.airport.location.lat, flightData[0].arrival.airport.location.lon)
        hotelData = await MapDataService.GetHotelsNearby(flightData[0].arrival.airport.location.lat, flightData[0].arrival.airport.location.lon)
    }
    return {
        props: { flightData: flightData, restaurantData: restaurantData, hotelData: hotelData },
    }
}
