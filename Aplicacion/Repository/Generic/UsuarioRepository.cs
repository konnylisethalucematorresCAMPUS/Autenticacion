//la condicion a la que nos referimos es la que creamos aqui, y aqui es donde declaramos un metodo llamado "GetByIdAsync" que toma un parametro id y el metodo "FindAsync" la que nos devuelve una tarea que representa el resultado de la búsqueda un objeto
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
public class UsuarioRepository : GenericRepository<Usuario>, IUsuario
{

    private readonly DbAppContext _Context;
    public UsuarioRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }

    public async Task<Usuario?> GetByIdAsync(long id) 
    {
        return await _Context.FindAsync<Usuario>(id); // retorna un objeto 
    }


}
