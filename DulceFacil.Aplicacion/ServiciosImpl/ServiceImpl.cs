using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServiciosImpl
{
    public class ServiceImpl<T> : IService<T> where T : class
    {
        private IRepository<T> repo;

        public ServiceImpl(DulceFacilContext context)
        {
            this.repo = new RepositoryImpl<T>(context);
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                await repo.AddAsync(entity);

            }
            catch (Exception ex)
            {

                throw new Exception("Error - Servicio: no se puede añadir la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await repo.DeleteAsync(id);

            }
            catch (Exception ex)
            {

                throw new Exception("Error - Servicio: no se puede eliminar la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await repo.GetAllAsync();

            }
            catch (Exception ex)
            {

                throw new Exception("Error - Servicio: no se puede obtener las entidades de la base " + ex.Message + ". ");
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await repo.GetByIdAsync(id);

            }
            catch (Exception ex)
            {

                throw new Exception("Error - Servicio: no se puede obtener la entidad a la base " + ex.Message + ". ");
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                await repo.UpdateAsync(entity);

            }
            catch (Exception ex)
            {

                throw new Exception("Error - Servicio: no se puede actualizar la entidad a la base " + ex.Message + ". ");
            }
        }
    }
}
