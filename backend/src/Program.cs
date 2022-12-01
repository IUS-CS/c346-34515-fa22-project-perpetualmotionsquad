using Interfaces.FlightService;
using Services.FlightService;
using Interfaces.GoogleService;
using Services.Google;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => 
{
    options.JsonSerializerOptions.IgnoreNullValues = true;
});

builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IGoogleService, GoogleService>();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
