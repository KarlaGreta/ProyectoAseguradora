using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ModificarTerceroUseCase : TerceroUseCase
{
   public ModificarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
   {      
   }

   public void Ejecutar(Tercero tercero)
   {
       if ((Repositorio.ListarTerceros().Where(x=>x.Id== tercero.Id).SingleOrDefault())!=null){
            Repositorio.ModificarTercero(tercero);
       }            
        else  throw new Exception($"error al modificar tercero = {tercero.Id}");
   }
}