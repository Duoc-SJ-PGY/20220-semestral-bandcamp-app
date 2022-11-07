using System.ComponentModel.DataAnnotations.Schema;

namespace TwitterAPI.Models;

public class Tweets
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    [ForeignKey("Usuario")]
    public int ID_Usuario { get; set; }
    public Usuario Usuario { get; set; }
    public string Texto { get; set; }
    public DateTime Fecha { get; set; }
    public int Retweets { get; set; }
    public int Likes { get; set; }
    public int Respuestas { get; set; }
}