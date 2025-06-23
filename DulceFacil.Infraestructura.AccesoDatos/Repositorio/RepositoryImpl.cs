using DulceFacil.Dominio.Modelos.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    //Implementación de IRepositoy, sin embargo, esta implementación es genérica, debe programarse para
    //interactuar con todas las entidades.
    public class RepositoryImpl<T> : IRepository<T> where T : class
    {
        private readonly DulceFacilContext _DulceFacilContext; //contexto creado, usado por nuestro framework
        private readonly DbSet<T> _dbSet; //como tal, interactua con la tabla

        //constructor para la implementación
        public RepositoryImpl(DulceFacilContext context)
        {
            _DulceFacilContext = context;
            _dbSet = context.Set<T>();
        }

        //añade una entidad al set luego hace un commit en la base de datos, guardando lo hecho.
        public async Task AddAsync(T entity)
        {
            try 
            { 
                await _dbSet.AddAsync(entity);
                await _DulceFacilContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase genérica: No se pudo insertar Datos" + ex.Message);
            }
           
        }

        //eliminar un registro, priemro hay que buscarlo (usando el método creado aquí), luego los removemos
        //del set y luego hacemos commit
        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                _dbSet.Remove(entity);
                await _DulceFacilContext.SaveChangesAsync();

            }

            catch (Exception ex) 
            {
                throw new Exception("Error - Clase genérica: No se pudo eliminar Datos" + ex.Message);

            }
        }

        //permite listar todos los registros en una tabla, super cool, ¿no?
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo traer los Datos" + ex.Message);
            }
        }

        //se encarga de buscar un registro dentro del dataset usando la id. Nos retorna una entidad
        public async Task<T> GetByIdAsync(int id)
        {
            try 
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex) 
            {
                throw new Exception("Error - Clase Genérica; No se pudo encontrar el dato" + ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _DulceFacilContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error - Clase Genérica; No se pudo actualizar el dato" + ex.Message);
            }
        }
    }
}
