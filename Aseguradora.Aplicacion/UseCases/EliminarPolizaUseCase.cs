using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class EliminarPolizaUseCase : PolizaUseCaseCase
{
   public EliminarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   {
   }

   public void Ejecutar(int id)
   {
       if ((Repositorio.ListarPolizas().Where(x=>x.Id == id).SingleOrDefault())!=null)
            Repositorio.EliminarPoliza(id);
            
        else  throw new Exception($"No existe un poliza con id = {id}");

   }
}