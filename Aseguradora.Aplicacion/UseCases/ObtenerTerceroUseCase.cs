using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ObtenerTerceroUseCase : TerceroUseCase
{
   public ObtenerTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
   {
   }

   public Tercero? Ejecutar(int id)
   {
       if( (Repositorio.ListarTerceros().SingleOrDefault(c => c.Id == id))!=null){
            return Repositorio.GetTercero(id);
       }else throw new Exception($" dtercero no existe = {id}");
       
   }
}