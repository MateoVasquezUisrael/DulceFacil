﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class TRutas
{
    public int RutaId { get; set; }

    public string RutaDetalles { get; set; }

    public int? RutaDuracion { get; set; }

    public string RutaDuracionUnidadMedida { get; set; }

    public virtual ICollection<TPedidos> TPedidos { get; set; } = new List<TPedidos>();
}