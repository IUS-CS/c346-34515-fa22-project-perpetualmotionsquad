import Link from 'next/link'
import FlightService from '../../../services/FlightsService'
import { useRouter } from 'next/router'

export default function flight ({ data }) {
    const router = useRouter()
    const { flightnumber, date } = router.query
    const resData = data
    return (
        <main>
            <h1>Flight Number = {flightnumber}</h1>
            <h1>Date = {date}</h1>
            <p>{resData}</p>
        </main>
    )
}

export async function getServerSideProps(context) {
    const flightNumber = context.params.flightnumber
    const date = context.params.date
    const flightData = await FlightService.GetFlightFromNumber(flightNumber,date)
    const stringFlightData = JSON.stringify(flightData)
    return {
      props: {data:stringFlightData},
    }
  }
