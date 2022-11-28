import { render, screen } from '@testing-library/react';
import {expect, jest, test} from '@jest/globals';
import Home from "../../pages/index"

//test home page
test('Home page title contains correct title', () => {
  render(<Home />);
  const element = screen.getByTestId('homeTitle')
  console.log(element.textContent)
  expect(element.textContent).toEqual("DestiNation");
});

test('Home page image src and alt contains correct value', () => {
  render(<Home />);
  const element = screen.getByTestId('homeImage')
  expect(element.src).toContain("airplane.png");
  expect(element.alt).toEqual("Airplane Image");
});
