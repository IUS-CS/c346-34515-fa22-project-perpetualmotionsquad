//Static UI Test
describe('ClickAboutUsLink',()=>{
  it('When you click About Us link it should direct the user to the about us page',()=>{
    cy.visit('http://localhost:3000/')
    cy.get('header[class="Homepage_header__oK_Nv"]').find("h2").click()
    cy.location('pathname').should('eq', '/about')
  })
})
describe('FlightNumberFormFilledOutPositive',()=>{
  it('When you click find flight after form is filled out properly it should navigate to flights page',()=>{
    cy.visit('http://localhost:3000/')
    cy.get("#flightNumber").type("SD5302")
    cy.get("#flightDate").type("2022-10-09")
    cy.get("#findFlightBtn").click()
    cy.location('pathname').should('eq', '/flight/SD5302/2022-10-09')
  })
})
describe('FlightNumberFormFilledOutNegative',()=>{
  it('When you click find flight after flight number is not in correct format it should stay at the index page',()=>{
    cy.visit('http://localhost:3000/')
    cy.get("#flightNumber").type("123456")
    cy.get("#flightDate").type("2022-10-09")
    cy.get("#findFlightBtn").click()
    cy.location('pathname').should('eq', '/')
  })
})