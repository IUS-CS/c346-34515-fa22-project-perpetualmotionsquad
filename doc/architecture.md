# Architecture Doc

![Thing](/doc/images/architecture.png?raw=true)

## Backend(.Net Web API)

### <ins>Aero API</ins>
#### Aero API is an external API that provides flight and airport data. When you make a request to this API you get back JSON.

### <ins>Controller</ins>
#### The controller receives a request from the Next JS Server and makes a request to Aero Api to get flight/airport data. The data received back is then mapped into various models and processed. The controller then sends this processed data back to the Next JS server as JSON.

### <ins>Model</ins>
#### The data we get back from Aero Api are put into various models making processing and changing the data simpler.

## Client

### <ins>Next JS Server</ins>
#### This is where our frontend application is hosted. The user receives a web page from this server when they make a request to it. This server also makes API requests to our .Net Web API and receives back data that is used to populate the page the user gets back.

### <ins>User's Browser</ins>
#### This is where the user interacts with our application making a request to the Next JS Server and getting back a web page.