using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ObtenerVehiculoUseCase : VehiculoUseCase
{
   public ObtenerVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   {
   }

   public Vehiculo? Ejecutar(int id)
   {
       if( (Repositorio.ListarVehiculos().SingleOrDefault(c => c.Id == id))!=null){
            return Repositorio.GetVehiculo(id);
       }else throw new Exception($" vehiculo no existe = {id}");
       
   }
}