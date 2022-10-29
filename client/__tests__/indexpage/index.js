import { render, screen } from '@testing-library/react';
import userEvent from '@testing-library/user-event'
import Home from "../../pages/index"

test('Home page title contains correct title', () => {
  render(<Home />);
  const element = screen.getByTestId('homeTitle')
  expect(element.textContent).toEqual("DestiNation");
});

test('Home page image src and alt contains correct value', () => {
  render(<Home />);
  const element = screen.getByTestId('homeImage')
  expect(element.src).toContain("airplane.png");
  expect(element.alt).toEqual("Airplane Image");
});

test('Home page link has the corrent link address and title', () => {
  render(<Home />);
  const element = screen.getByText("About Us")
  expect(element.getAttribute("href")).toEqual("/about")
  expect(element.textContent).toEqual("About Us");
});

test('Search Flight Form Invalid Flight Number', async () => {
  render(<Home />);
  const flightNumberInput = screen.getByTestId("flightNumberInput")
  const dateInput = screen.getByTestId("flightNumberDateInput")
  const submitFromInput = screen.getByTestId("submitFlightNumberBtn")
  const flightNumberForm = screen.getByTestId("flightNumberForm")
  await userEvent.type(flightNumberInput, "DL9367");
  await userEvent.type(dateInput, "2022-10-29")
  await userEvent.click(submitFromInput) 
});

