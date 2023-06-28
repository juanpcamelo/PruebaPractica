using Practical.Application.DTOs.Response;

namespace PracticalApplication.Test.WebApi.TheoryTest
{
    public class CustomerTheory : TheoryData<IEnumerable<ViewClientPolicy>>
    {
        public CustomerTheory()
        {
            Add(new List<ViewClientPolicy>()
            {
                new ViewClientPolicy
                {
                    Id = Guid.NewGuid().ToString(),
                    FechaNacimientoCliente = DateTime.Now,
                    Coberturas = "100",
                    DireccionResidenciaCliente = "tets",
                    CiudadResidenciaCliente = "test",
                    FechaPoliza = DateTime.Now,
                    IdentificacionCliente = "12548",
                    ModeloAutomotor = "",
                    NombreCliente = "test",
                    NombrePlan = "test",
                    PlacaAutomotor= "test",
                    TieneInspeccionVehiculo = true,
                    ValorMaximoCubierto = 100
                }
            });
        }
    }
}
