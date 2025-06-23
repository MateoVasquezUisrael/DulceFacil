using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelos.Abstracciones
{
    public class TRutasRepoImpl : RepositoryImpl<TRutas>, ITRutas
    {
        public TRutasRepoImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
