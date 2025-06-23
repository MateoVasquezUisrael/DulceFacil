using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelos.Abstracciones
{
    // Interfaz generica usada para que toda entidad puede implementarse
    // Su implementación se debe hacer en DulceFcil.infraestructura.AccesoDatos.Repositorio
    public interface IRepository <T> where T : class
    {
        Task AddAsync(T entity); //Encargada de añadir una entidad en surespectiva tabla, usa el dato
                                 //Task por cosas de EF Core

        Task UpdateAsync(T entity); //Encargada de actualizar un registro dentro de una tabla. A saber cómo lo logra
       
        Task DeleteAsync(int id); //Encargada de eliminar un registro de la tabla siempre que se sepa su id.

        Task<IEnumerable<T>> GetAllAsync(); //Encargada de traer todos los registros de la tabla.

        Task<T> GetByIdAsync(int id); //Encargada de traer un registro de la tabla, este si es un Task<T>
                                      //ya que debe devolver la entidad del registro adecuado.
    }
}
