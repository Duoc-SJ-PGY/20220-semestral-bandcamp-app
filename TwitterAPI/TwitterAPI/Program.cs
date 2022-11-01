using TwitterAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

List<Usuario> usuarios = new List<Usuario>();

app.MapGet("/Usuarios", () =>
{
    return usuarios;
});

app.MapPost("/Usuarios", (Usuario usuario) =>
{
    if (usuario.Id == 0)
        return StatusCodes.Status404NotFound;
    var user = usuarios.Find(x => x.Id == usuario.Id);
    if (user != null)
        return StatusCodes.Status400BadRequest;
    usuarios.Add(usuario);
    return StatusCodes.Status200OK;
});

app.MapDelete("/Usuario", (int id) =>
{
    var user = usuarios.FirstOrDefault(x => x.Id == id);
    if (user == null)
        return StatusCodes.Status404NotFound;
    usuarios.Remove(user);
    return StatusCodes.Status200OK;
});

app.MapPut("/Usuario", (Usuario usuario) =>
{
    var user = usuarios.FirstOrDefault(x => x.Id == usuario.Id);
    if (user == null)
        return StatusCodes.Status404NotFound;
    user = usuario;
    return StatusCodes.Status200OK;
});

















app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}