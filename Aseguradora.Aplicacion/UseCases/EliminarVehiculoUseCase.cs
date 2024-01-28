using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class EliminarVehiculoUseCase : VehiculoUseCase
{
   public EliminarVehiculoUseCase(IRepositorioVehiculo repositorio) : base(repositorio)
   {
   }

   public void Ejecutar(int id)
   {
       if ((Repositorio.ListarVehiculos().Where(x=>x.Id == id).SingleOrDefault())!=null)
            Repositorio.EliminarVehiculo(id);
            
        else  throw new Exception($"No existe un vhiculo con id = {id}");

   }
} 