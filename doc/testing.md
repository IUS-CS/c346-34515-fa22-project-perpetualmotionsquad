# Testing Documentation

## Frontend Testing
---

For our frontend testing we are using the Jest framework for node. We are testing that elements on our frontend contain the values that we expect. We will add more testing as we add more features.

**To run the fronend tests navigate to the client/\_\_tests\_\_ directory and run the following command:**

```console
npm test
```

## Backend Testing
---

For our backend testing we are using xunit to run unit tests on dotnet. We are checking that our flightnumbers are returning what we expect. We are using Moq to run those as mock tests. We will add more testing as we add more features.

**To run the backend tests navigate to the backend/tests directory and run the following command:**

```console
dotnet test
```

## GitHub Actions
---

We have also setup our github actions to test that our frontend and back end build and then run their tests anytime we make a commit.