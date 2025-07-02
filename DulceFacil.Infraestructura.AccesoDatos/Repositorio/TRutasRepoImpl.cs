using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class TRutasRepoImpl : RepositoryImpl<TRutas>, ITRutas
    {
        public TRutasRepoImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
