using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ListarVehiculoUseCase : VehiculoUseCase
{
   public ListarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   {
   }

   public List<Vehiculo> Ejecutar()
   {
       return Repositorio.ListarVehiculos();
   }
}