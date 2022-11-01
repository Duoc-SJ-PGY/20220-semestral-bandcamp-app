namespace TwitterAPI.Models;

public class Usuario
{
    public int ID { get; set; }

    public string Nick { get; set; }
    
    public string Nombre { get; set; }
    
    public string Apellido { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string UrlImagen { get; set; }
    
    public DateTime FechaIngreso { get; set; }
}