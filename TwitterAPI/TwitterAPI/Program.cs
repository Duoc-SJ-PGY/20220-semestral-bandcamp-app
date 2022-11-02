using TwitterAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

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
List<Tweet> tweets = new List<Tweet>();

app.MapGet("/Usuarios", () =>
{
    return usuarios;
});

app.MapGet("/Usuarios/{id}", (int id) =>
{
    return usuarios.FirstOrDefault(x => x.Id == id);
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
    user.Apellido = usuario.Apellido;
    user.Nombre = usuario.Nombre;
    user.Correo = usuario.Correo;
    user.Password = usuario.Password;
    user.Nick = usuario.Nick;
    return StatusCodes.Status200OK;
});

app.MapGet("/Tweets", () =>
{
    return tweets;
});

app.MapGet("/Tweets/{id}", (int id) =>
{
    return tweets.FindAll(x => x.ID_Usuario == id);
});
app.MapPost("Tweets/", (Tweet tweet) =>
{
    var user = usuarios.Find(x => x.Id == tweet.ID_Usuario);
    if (user == null)
        return StatusCodes.Status400BadRequest;
    tweets.Add(tweet);
    return StatusCodes.Status200OK;
});


app.Run();

