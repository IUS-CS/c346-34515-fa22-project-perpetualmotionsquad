## Design Patterns In Use
---

We are currently using a singleton design pattern. Our constructor on the FlightService class is set to private so that it constructs itself and it is the only one able to construct itself. We have two controllers who both use the FlightService class depending on the search options used by the user. The FlightService class is using an Interface called IFlightService as well.

## Design Patters Which May Be Used
---

It may be useful to use the mediator pattern. The mediator would allow us to keep objects from referring to each other and would let us vary their interaction independently. This would be useful in the user interface of the project. The user's inputs would go to the mediator who would then parse the requests between searching by arrival flights or by flight number.

## Plans for Future Use
---

We may be able to redesign our search page to allow users to input several search criteria into one location on the index.js page. Once the user inputs the data the mediator class would be able to switch between using the FlightsController or the ArrivalFlightsController to search for the flight data. This would allow us to make changes down the road to how the backend is structured without having to make changes to the way users search on the frontend. We would just make adjustments to the mediator to account for backend changes.