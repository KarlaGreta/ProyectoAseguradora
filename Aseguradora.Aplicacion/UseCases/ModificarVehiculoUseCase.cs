using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ModificarVehiculoUseCase : VehiculoUseCase
{
   public ModificarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   {      
   }

   public void Ejecutar(Vehiculo vehiculo)
   {
       if ((Repositorio.ListarVehiculos().Where(x=>x.Id== vehiculo.Id).SingleOrDefault())!=null){
            Repositorio.ModificarVehiculo(vehiculo);
       }            
        else  throw new Exception($"error al modificar vehiculo = {vehiculo.Id}");
   }
}