using TwitterAPI.Models;

namespace TwitterAPI.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public Task<Usuario> GetUsuario(string usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddUsuario(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUsuario(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUsuario(string usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Usuario>> GetSeguidores(string usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Usuario>> GetSeguidos(string usuarioId)
    {
        throw new NotImplementedException();
    }
}