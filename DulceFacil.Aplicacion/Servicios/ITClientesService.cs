﻿using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.Servicios
{
    [ServiceContract]
    public interface ITClientesService: IService<TClientes>
    {
    }
}
