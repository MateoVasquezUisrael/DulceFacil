using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{

    public class TProductosPuntoVentaRepoImpl : RepositoryImpl<TProductosPuntoVenta>, ITProductosPuntoVenta
    {
        public TProductosPuntoVentaRepoImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
