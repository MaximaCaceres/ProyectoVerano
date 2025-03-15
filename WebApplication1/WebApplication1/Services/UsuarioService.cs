using WebApplication1.Models;
using WebApplication1.DAOs.MSSDAOs;

namespace WebApplication1.Services
{
    public class UsuarioService
    {
        UsuarioDAO dao = new UsuarioDAO();
        async public Task<bool> VerificarLogin(Usuario usuarioVerificar)
        {
            var usuario = await dao.GetByKey(usuarioVerificar.Nombre);
            return usuario != null && usuarioVerificar.Clave == usuario.Clave;
        }

        async public Task<List<Usuario>> GetAll()
        {
            return await dao.GetAll();
        }

        async public Task<Usuario?> GetByNombre(string nombre)//retorna usuario en base al nombre.
        {
            return await dao.GetByKey(nombre);
        }

        async public Task<bool> CrearNuevo(Usuario persona)
        {
            return await dao.Insert(persona);
        }

        async public Task<bool> Actualizar(Usuario persona)
        {
            return await dao.Update(persona);
        }

        async public Task<bool> Eliminar(string nombre)
        {
            return await dao.Delete(nombre);
        }
    }
}
