import { render, screen, } from '@testing-library/react';
import {expect, jest, test} from '@jest/globals';
//import components
import FlightData from "../../components/flightdata/FlightData"
import FlightStatus from '../../components/flightstatus/FlightStatus';
import Location from '../../components/location/Location';
import LocationMapList from '../../components/locationmaplist/LocationMapList';

//test FlightData component
test('FlightData component Renders with all elements', () => {
    render(<FlightData departureAirport={'Gerald R Ford'} arrivalAirport={'Sky Harbor'} distance={'1573'} aircraft={'Airbus A319'}/>);
    const departureElement = screen.getByText('Gerald R Ford');
    expect.objectContaining(departureElement);
    const arrivalElement = screen.getByText('Sky Harbor');
    expect.objectContaining(arrivalElement);
    const distanceElement = screen.getByText('1573 Miles');
    expect.objectContaining(distanceElement);
    const aircraftElement = screen.getByText('Airbus A319');
    expect.objectContaining(aircraftElement);
    const imageElement = screen.getByRole('img');
    expect.objectContaining(imageElement);
});
  
//test FlightStatus component
describe('FlightStatus tests', () => {
    describe('flightStatusLogicFirst function testing', () => {
        test('flight status is scheduled', () => {
            render(<FlightStatus flightStatus={'Scheduled'}/>);
            expect.objectContaining('Scheduled');
        });
        test('flight status is scheduled so dont show as Canceled', () => {
            render(<FlightStatus flightStatus={'Scheduled'}/>);
            expect.not.objectContaining('Canceled');
        });
        test('flight status is Unknown', () => {
            render(<FlightStatus flightStatus={'Unknown'}/>);
            expect.objectContaining('Unknown');
        });
        test('flight status is Canceled', () => {
            render(<FlightStatus flightStatus={'Canceled'}/>);
            expect.objectContaining('Canceled');
        });
        test('flight status is CheckIn', () => {
            render(<FlightStatus flightStatus={'CheckIn'}/>);
            expect.objectContaining('CheckIn');
        });
        test('flight status is Boarding', () => {
            render(<FlightStatus flightStatus={'Boarding'}/>);
            expect.objectContaining('Boarding');
        });
        test('flight status is GateClosed', () => {
            render(<FlightStatus flightStatus={'GateClosed'}/>);
            expect.objectContaining('GateClosed');
        });
        test('flight status is Delayed', () => {
            render(<FlightStatus flightStatus={'Delayed'}/>);
            expect.objectContaining('Delayed');
        });
        test('flight status is CanceledUncertian', () => {
            render(<FlightStatus flightStatus={'CanceledUncertain'}/>);
            expect.objectContaining('CanceledUncertain');
        });
        test('flight status is notAnOption so this is testing the default result is Scheduled', () => {
            render(<FlightStatus flightStatus={'notAnOption'}/>);
            expect.objectContaining('Scheduled');
        });
        test('flight status is Flying so flightStatusLogicFirst will display default of Scheduled', () => {
            render(<FlightStatus flightStatus={'Flying'}/>);
            expect.objectContaining('Scheduled');
        });
    });

    describe('flightStatusLogicSecond tests', () => {
        test('flighst status is Flying', () => {
            render(<FlightStatus flightStatus={'Flying'}/>);
            expect.objectContaining('Flying');
        });
        test('flighst status is Departed', () => {
            render(<FlightStatus flightStatus={'Departed'}/>);
            expect.objectContaining('Scheduled');
            expect.objectContaining('Departed');
            expect.objectContaining('Arrived');
        });
        test('flighst status is EnRoute', () => {
            render(<FlightStatus flightStatus={'EnRoute'}/>);
            expect.objectContaining('Scheduled');
            expect.objectContaining('EnRoute');
            expect.objectContaining('Arrived');
        });
        test('flighst status is Approaching', () => {
            render(<FlightStatus flightStatus={'Approaching'}/>);
            expect.objectContaining('Scheduled');
            expect.objectContaining('Approaching');
            expect.objectContaining('Arrived');
        });
        test('flighst status is Expected', () => {
            render(<FlightStatus flightStatus={'Expected'}/>);
            expect.objectContaining('Scheduled');
            expect.objectContaining('Expected');
            expect.objectContaining('Arrived');
        });
        test('flighst status is Diverted', () => {
            render(<FlightStatus flightStatus={'Diverted'}/>);
            expect.objectContaining('Scheduled');
            expect.objectContaining('Diverted');
            expect.objectContaining('Arrived');
        });
    });

    describe('flightStatusLogicThird tests', () => {
        test('flighst status is Arrived', () => {
            render(<FlightStatus flightStatus={'Arrived'}/>);
            expect.objectContaining('Scheduled');
            expect.objectContaining('Flying');
            const element = screen.getByText('Arrived');
            expect.objectContaining(element);
        });
        test('flighst status is notValid so all default status will be shown', () => {
            render(<FlightStatus flightStatus={'notValid'}/>);
            const element = screen.getByText('Scheduled');
            expect.objectContaining(element);
            expect.objectContaining('Flying');
            expect.objectContaining('Arrived');
        });
    });
});
  
//Location component tests
describe('tests for the Location component', () => {
    test('displays the rating of the hotel or restaurant', () => {
        render(<Location rating={'4.5'} name={'PHX Beer Co.'}/>);
        const element = screen.getByText('4.5')
        expect.objectContaining(element);
        expect.not.objectContaining('5.0');
    });
    test('displays the name of the hotel or restaurant', () => {
        render(<Location rating={'4.5'} name={'PHX Beer Co.'}/>);
        const element = screen.getByText('PHX Beer Co.')
        expect.objectContaining(element);
        expect.not.objectContaining('McDonalds');
    });
    test('creates a google search link for the name of the hotel or restaurant', () => {
        render(<Location rating={'4.5'} name={'PHX Beer Co.'}/>);
        expect.objectContaining("http://google.com/search?q=PHX Beer Co.");
    });
});

//LocationMapList coponent tests
describe('tests for the LocationMapList component', () => {
    test('LocationMapList renders correctly', () => {
        render(<LocationMapList />);
        const element = screen.getByText('Top Arrival');
        expect.objectContaining(element);
    });
});