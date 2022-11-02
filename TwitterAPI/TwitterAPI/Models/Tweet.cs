namespace TwitterAPI.Models;

public class Tweet
{
    public int ID { get; set; }
    public int ID_Usuario { get; set; }
    public string Texto { get; set; }
    public DateTime Fecha { get; set; }
    public int Retweets { get; set; }
    public int Likes { get; set; }
    public int Respuestas { get; set; }
}