using TwitterAPI.Models;

namespace TwitterAPI.Data.Repositories;

public interface IUsuarioRepository
{
    Task<Usuario> GetUsuario(string usuarioId);
    Task<bool> AddUsuario(Usuario usuario);
    Task<bool> UpdateUsuario(Usuario usuario);
    Task<bool> DeleteUsuario(string usuarioId);
    Task<List<Usuario>> GetSeguidores(string usuarioId);
    Task<List<Usuario>> GetSeguidos(string usuarioId);
    // Task AddTweet(string usuarioId, Tweet tweet);
    // Task AddSeguidor(string usuarioId, string seguidorId);
    // Task AddSeguido(string usuarioId, string seguidoId);
    // Task RemoveSeguidor(string usuarioId, string seguidorId);
    // Task RemoveSeguido(string usuarioId, string seguidoId);
    // Task<List<Usuario>> GetSeguidores(string usuarioId);
    // Task<List<Usuario>> GetSeguidos(string usuarioId);
}