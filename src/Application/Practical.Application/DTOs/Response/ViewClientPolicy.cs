namespace Practical.Application.DTOs.Response
{
    public class ViewClientPolicy
    {
        public string Id { get; set; } = string.Empty;
        public string NombreCliente { get; set; } = string.Empty;
        public string IdentificacionCliente { get; set; } = string.Empty;
        public DateTime FechaNacimientoCliente { get; set; }
        public DateTime FechaPoliza { get; set; }
        public string Coberturas { get; set; } = string.Empty;
        public decimal ValorMaximoCubierto { get; set; }
        public string NombrePlan { get; set; } = string.Empty;
        public string CiudadResidenciaCliente { get; set; } = string.Empty;
        public string DireccionResidenciaCliente { get; set; } = string.Empty;
        public string PlacaAutomotor { get; set; } = string.Empty;
        public string ModeloAutomotor { get; set; } = string.Empty;
        public bool TieneInspeccionVehiculo { get; set; }
    }
}
