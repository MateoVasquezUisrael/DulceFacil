using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Aplicacion.ServiciosImpl;
using DulceFacil.Dominio.Modelos.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TestUnitarios
{
    public class Tests
    {
        private ITClientesService clientesService;
        private ITClientesTipoService clientesTipoService;
        private ITRutasService rutasService;
        private DulceFacilContext context;

        [SetUp]
        public void Setup()
        {
            var opciones = new DbContextOptionsBuilder<DulceFacilContext>()
                .UseSqlServer("Data Source=DESKTOP-NCNTGBP\\MIPRIMERSQL2024;Initial Catalog=DulceFacil;Integrated Security=True; TrustServerCertificate=True;")
                .Options;

            context = new DulceFacilContext(opciones);
            clientesTipoService = new TClientesTipoServiceImpl(context);
            rutasService = new TRutasServiceImpl(context);
            clientesService = new TClientesServiceImpl(context);

        }

        [Test]
        public async Task SuperPruebas()
        {
            /*
            var pruebaTRutas = new TRutas
            {
             RutaDetalles = "Desde el Norte de Quito, pasando por la Ave. Amazonas, por todo Quito"
            ,RutaDuracion = 20
            };
            */
            //await clientesTipoService.AddAsync(pruebaTClientesTipo);

            //NO OLVIDES INSTANCIAR EL SERVICIO, SINO NO FUNCIONA

            //para añadir un tipo de dato que tiene foreign key es solo necesario ver que la id si es la correcta. Si la Id
            //no existe en la base, no se ingresa.
            //Para la fecha, verificar que sea DateOnly
            var pruebaTClientes = new TClientes
            {
                ClienteNombre = "Mateo",
                ClienteApellido = "Vasquez",
                ClienteCedula = "1752779908",
                ClienteEmail = "email",
                ClienteFechaNac = new DateOnly(2003, 05, 21),
                ClienteTipoId = 2,
                ClienteTelf = "0958882608",
       
            };

            await clientesService.AddAsync(pruebaTClientes);
            var clientes = await clientesService.GetAllAsync();
             //me permite ver la cantidad de entidades en la base de datos.
            Console.WriteLine(clientes.Count());
            Assert.Pass();
        }

        [TearDown]
        public void Teardown()
        {
            context.Dispose();
        }
    }
}