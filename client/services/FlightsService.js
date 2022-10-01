import axios from "axios"
import https from "https"

class FlightService {
  static async GetFlightFromNumber(flightNumber, date) {
    //Remove is. You don't want to have this
    axios.defaults.httpsAgent = new https.Agent({
      rejectUnauthorized: false
    })
    
    const config = {
      method: 'GET',
      url: "https://localhost:7072/flights/flightnumber",
      params: { flightnumber: flightNumber, date: date }
    }

    try {
      const response = await axios(config)
      return response.data;
    }
    catch (err) {
      console.log(err)
      return {}
    }

  }
}

export default FlightService