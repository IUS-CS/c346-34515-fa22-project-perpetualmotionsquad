import axios from "axios"
import https from "https"

class MapsDataService {
  static async GetRestaurantsNearby(latitude,longitude) {
    //Remove is. You don't want to have this
    axios.defaults.httpsAgent = new https.Agent({
      rejectUnauthorized: false
    })
    const config = {
      method: 'GET',
      url: "https://localhost:7072/restautants/location",
      params: { lat: latitude, lng: longitude }
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

export default MapsDataService