using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class EliminarTerceroUseCase : TerceroUseCase
{
   public EliminarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
   {
   }

   public void Ejecutar(int id)
   {
       if ((Repositorio.ListarTerceros().Where(x=>x.Id == id).SingleOrDefault())!=null)
            Repositorio.EliminarTercero(id);
            
        else  throw new Exception($"No existe un Tercero con id = {id}");

   }
}