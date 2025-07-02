using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    
    public class TCentrosDistribucionRepoImpl : RepositoryImpl<TCentrosDistribucion>, ITCentrosDistribucion
    {
        public TCentrosDistribucionRepoImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
