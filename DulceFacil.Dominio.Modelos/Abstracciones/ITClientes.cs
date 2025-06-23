using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelos.Abstracciones
{
    //interface para la tabla correspondiente, lo que se hace es que se quita la T y se añade el tipo de clase
    //que usará los métodos. Debe de implementarse, puesta interfaz hereda de IRepository
    public interface ITClientes : IRepository<TClientes>
    {
    }
}
