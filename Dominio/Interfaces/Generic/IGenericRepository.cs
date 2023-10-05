//Despues realizamos el metodo generico llamdo FindFirst
using System.Linq.Expressions;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IGenericRepository<T> where T : BaseEntity{

        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<T> FindFirst(Expression<Func<T, bool>> expression);// despues se creo este metodo el cual va a buscar a la primera entidad en el repositorio que cumpla con la condición específica que vamos a crear en el repositorio.

        Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        
    }
