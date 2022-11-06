namespace TwitterAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nick { get; set; }

        public string Password { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string UrlImage { get; set; }

        public DateTime FechaIngreso { get; set; }

        public int CantidadSeguidos { get; set; }

        public int CantidadSeguidores { get; set; }
    }
}
