using TwT.Services.Weather;

var flasher = new CustomFlasher(args);

// Add services to the container.
flasher.ApplicationBuilder.Services.AddEndpointsApiExplorer();
flasher.ApplicationBuilder.Services.AddSwaggerGen();

//Boot the 'flashed' logic
flasher.BootUp();

// Configure the HTTP request pipeline.
if (flasher.Application.Environment.IsDevelopment())
{
	flasher.Application.UseSwagger();
	flasher.Application.UseSwaggerUI();
}

flasher.Application.UseHttpsRedirection();

flasher.Application.MapGet("/status", () =>
{
	return "OK";
})
.WithName("GetWeatherForecast")
.WithOpenApi();

flasher.Application.Run();