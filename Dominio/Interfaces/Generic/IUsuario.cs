// Para poder realizar la condicion creamos una interfaz llamada Isuario la cual contiene el metodo especifico para buscar usuarios por Id de manera asincronica
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IUsuario : IGenericRepository<Usuario>
    {

        Task<Usuario?> GetByIdAsync(long id);
        
    }
