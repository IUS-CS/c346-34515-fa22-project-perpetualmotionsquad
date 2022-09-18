// cypress/integration/app.spec.js
describe('Test', () => {
  it('First page should contain a h1 that contains PerpetualMotion ', () => {
    cy.visit('http://localhost:3000/')
    cy.get('h1').contains('PerpetualMotion')
  })
})