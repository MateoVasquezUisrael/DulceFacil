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
    public class TClientesTipoServiceImpl : ServiceImpl<TClientesTipo>, ITClientesTipoService
    {
        public TClientesTipoServiceImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
