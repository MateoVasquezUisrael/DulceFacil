using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelos.Abstracciones
{
    // Interfaz generica usada para que toda entidad puede implementarse
    public interface IRepository <T> where T : class
    {
        Task AddAsync(T entity); //Encargada de añadir una entidad en surespectiva tabla, usa el dato
                                 // Task por cosas de EF Core

        Task UpdateAsync(T entity); //Encargada de actualizar un registro dentro de una tabla. A saber cómo lo logra
       
        Task DeleteAsync(T entity);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
