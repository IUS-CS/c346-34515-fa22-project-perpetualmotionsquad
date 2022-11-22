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
    }
}

export default function flight({ flightData, restaurantData }) {
    console.log(flightData)
    const flightStatus = flightData[0].status
    const arrivalAirport = flightData[0].arrival.airport.shortName
    const departureAirport = flightData[0].departure.airport.shortName
    const distance = flightData[0].greatCircleDistance.mile
    const aircraft = flightData[0].aircraft.model
    const aircraftImg = flightData[0].aircraft.image.url
    return (
        <div className={styles.flightPageContainer}>
            <div className={styles.leftPageContainer}>
                {flightStatusHeaderText(flightStatus, arrivalAirport)}
                <FlightStatus flightStatus={flightStatus}></FlightStatus>
                <FlightData arrivalAirport={arrivalAirport} departureAirport={departureAirport} distance={distance} aircraft={aircraft} aircraftImgUrl = {aircraftImg}></FlightData>
            </div>
            <div className={styles.rightPageContainer}>
                <LocationMapList listData={restaurantData.results} i></LocationMapList>
                <LocationMapList></LocationMapList>
            </div>
        </div>
    )
}
export async function getServerSideProps(context) {
    const flightNumber = context.params.flightnumber
    const date = context.params.date
    const flightData = await FlightService.GetFlightFromNumber(flightNumber, date)
    if (flightData != null) {
        var restaurantData = await MapDataService.GetRestaurantsNearby(flightData[0].arrival.airport.location.lat, flightData[0].arrival.airport.location.lon)
    }
    return {
        props: { flightData: flightData, restaurantData: restaurantData },
    }
}
