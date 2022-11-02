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
usuarios.Add(new Usuario() { Id = 1, Nick = "Anticucho", Correo = "testing@gmail.com", Password = "123456", Nombre = "Jorge", 
    Apellido = "Munoz", CantidadSeguidores = 1422, CantidadSeguidos = 123,  FechaIngreso = new DateTime(2021, 12, 12), 
    UrlImage = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/144.png"});
usuarios.Add(new Usuario() { Id = 2, Nick = "Anticucho2", Correo = "testing@gmail.com", Password = "123456", Nombre = "Jorge", 
    Apellido = "Munoz", CantidadSeguidores = 1422, CantidadSeguidos = 123,  FechaIngreso = new DateTime(2021, 12, 12),
    UrlImage = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/144.png"});
usuarios.Add(new Usuario() { Id = 3, Nick = "Anticucho3", Correo = "testing@gmail.com", Password = "123456", Nombre = "Jorge", 
    Apellido = "Munoz", CantidadSeguidores = 1422, CantidadSeguidos = 123,  FechaIngreso = new DateTime(2021, 12, 12),
    UrlImage = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/144.png"});

List<Tweet> tweets = new List<Tweet>();

tweets.Add(new Tweet() { ID = 1, ID_Usuario = 1, Fecha = new DateTime(), Texto = "Hola mundo", Retweets = 12, Likes = 543, Respuestas = 2 });
tweets.Add(new Tweet() { ID = 2, ID_Usuario = 1, Fecha = new DateTime(), Texto = "Chao mundo", Retweets = 14, Likes = 122, Respuestas = 4 });
tweets.Add(new Tweet() { ID = 3, ID_Usuario = 1, Fecha = new DateTime(), Texto = "Holiwis mundo", Retweets = 100, Likes = 15, Respuestas = 5 });
tweets.Add(new Tweet() { ID = 4, ID_Usuario = 1, Fecha = new DateTime(), Texto = "Chaiwis mundo", Retweets = 2, Likes = 180, Respuestas = 3 });
tweets.Add(new Tweet() { ID = 5, ID_Usuario = 1, Fecha = new DateTime(), Texto = "HOLANDA mundo", Retweets = 12, Likes = 10, Respuestas = 7 });


app.MapPost("/Login/", (string nick, string pass) =>
{
    var usuario = usuarios.FirstOrDefault(x => x.Nick == nick && x.Password == pass);
    return usuario != null;
});
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

app.MapGet("/Tweets/", () =>
{
    return tweets;
});

app.MapGet("/Tweets/{id}", (int id) =>
{
    return tweets.FindAll(x => x.ID_Usuario == id);
});
app.MapPost("/Tweets/", (Tweet tweet) =>
{
    var user = usuarios.Find(x => x.Id == tweet.ID_Usuario);
    if (user == null)
        return false;
    tweets.Add(tweet);
    return true;
});


app.Run();

