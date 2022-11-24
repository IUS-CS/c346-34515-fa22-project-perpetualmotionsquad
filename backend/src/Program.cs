using Interfaces.FlightService;
using Services.FlightService;
using Interfaces.RestautantService;
using Services.Restaurant;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => 
{
    options.JsonSerializerOptions.IgnoreNullValues = true;
});

builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
