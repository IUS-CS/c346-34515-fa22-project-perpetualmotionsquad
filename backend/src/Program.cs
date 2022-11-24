using Interfaces.FlightService;
using Services.FlightService;
using Interfaces.RestaurantService;
using Services.Restaurant;
using Interfaces.HotelService;
using Services.Hotel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => 
{
    options.JsonSerializerOptions.IgnoreNullValues = true;
});

builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IHotelService, HotelService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
