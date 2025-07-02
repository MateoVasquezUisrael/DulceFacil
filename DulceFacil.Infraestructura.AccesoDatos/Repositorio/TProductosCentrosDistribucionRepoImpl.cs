using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    //interface para la tabla correspondiente, lo que se hace es que se quita la T y se añade el tipo de clase
    //que usará los métodos. Debe de implementarse, puesta interfaz hereda de IRepository
    public class TProductosCentrosDistribucionRepoImpl : RepositoryImpl<TProductosCentrosDistribucion>, ITProductosCentrosDistribucion
    {
        public TProductosCentrosDistribucionRepoImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
