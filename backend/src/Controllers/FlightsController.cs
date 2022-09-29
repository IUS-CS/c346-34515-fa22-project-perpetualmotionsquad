using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlightApi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace OwnApi.Controllers;

[Route("[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{



    // GET: Flights/flightnumer?flightnumber=1234
    [HttpGet("flightnumber")]
    public async Task<ActionResult<Flight>> GetFlight(string? flightnumber)
    {
        var flight = await CallingApiFlight(flightnumber);
        return flight;
    }




    public static async Task<Flight> CallingApiFlight(string s)
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key","{Api Key}");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host","aerodatabox.p.rapidapi.com");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        // client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


        var streamTask = client.GetStreamAsync($"https://aerodatabox.p.rapidapi.com/flights/number/{s}/2022-09-27?withAircraftImage=true&withLocation=true");
        var flight = await JsonSerializer.DeserializeAsync<List<Flight>>(await streamTask);
        return flight[0];
    }
}