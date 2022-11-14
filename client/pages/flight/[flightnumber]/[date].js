import Link from 'next/link'
import styles from "../../../styles/pagestyles/FlightPage.module.css"
import FlightService from '../../../services/FlightsService'
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
        case "Flying":
            return <h1>Get Ready To Be In {arrivalAirport}</h1>
        case "Canceled":
            return <h1>Sorry, This Flight Has Been Canceled</h1>
        case "Arrived":
            return <h1>Welcome To {arrivalAirport}</h1>
    }
}

export default function flight({ data }) {
    const router = useRouter()
    const { flightnumber, date } = router.query
    const resData = JSON.parse(data)
    const flightStatus = resData.status
    const arrivalAirport = resData.arrival.airport.name
    return (
        <div className={styles.flightPageContainer}>
            <div className={styles.leftPageContainer}>
                {flightStatusHeaderText(flightStatus, arrivalAirport)}
                <FlightStatus flightStatus={flightStatus}></FlightStatus>
                <FlightData></FlightData>
            </div>
            <div className={styles.rightPageContainer}>
                <LocationMapList></LocationMapList>
                <LocationMapList></LocationMapList>
            </div>
        </div>
    )
}

export async function getServerSideProps(context) {
    const flightNumber = context.params.flightnumber
    const date = context.params.date
    //const flightData = await FlightService.GetFlightFromNumber(flightNumber,date)
    const flightData = [{ "greatCircleDistance": { "meter": 1980766.89, "km": 1980.767, "mile": 1230.791, "nm": 1069.529, "feet": 6498579.04 }, "departure": { "airport": { "icao": "KDFW", "iata": "DFW", "name": "Dallas-Fort Worth, Dallas Fort Worth", "shortName": "Dallas Fort Worth", "municipalityName": "Dallas-Fort Worth", "location": { "lat": 32.8968, "lon": -97.038 }, "countryCode": "US" }, "scheduledTimeLocal": "2022-10-29 18:30-05:00", "scheduledTimeUtc": "2022-10-29 23:30Z", "terminal": "0", "quality": ["Basic"] }, "arrival": { "airport": { "icao": "KMDT", "iata": "MDT", "name": "Harrisburg", "shortName": "Harrisburg", "municipalityName": "Harrisburg", "location": { "lat": 40.1935, "lon": -76.7634 }, "countryCode": "US" }, "scheduledTimeLocal": "2022-10-29 22:25-04:00", "scheduledTimeUtc": "2022-10-30 02:25Z", "quality": ["Basic"] }, "number": "AA 546", "status": "Scheduled", "codeshareStatus": "Unknown", "isCargo": false, "aircraft": { "model": "Airbus A319", "image": { "url": "https://farm66.staticflickr.com/65535/52301300663_edee17a549_z.jpg", "webUrl": "https://www.flickr.com/photos/23089307@N02/52301300663/", "author": "beltz6", "title": "Touchdown SBA!", "description": "American Airlines Airbus A319, registration N768US.", "license": "AttributionCC", "htmlAttributions": ["Original of \"<span property='dc:title' itemprop='name'>Touchdown SBA!</span>\" by <a rel='dc:creator nofollow' property='cc:attributionName' href='https://www.flickr.com/photos/23089307@N02/52301300663/' target='_blank'><span itemprop='producer'>beltz6</span></a>.", "Shared and hosted by <span itemprop='publisher'>Flickr</span> under <a target=\"_blank\" rel=\"license cc:license nofollow\" href=\"https://creativecommons.org/licenses/by/2.0/\">CC BY</a>"] } }, "airline": { "name": "American" } }]
    const stringFlightData = JSON.stringify(flightData[0])
    return {
        props: { data: stringFlightData },
    }
}
