using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ObtenerPolizaUseCase : PolizaUseCaseCase
{
   public ObtenerPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   {
   }

   public Poliza? Ejecutar(int id)
   {
       if( (Repositorio.ListarPolizas().SingleOrDefault(c => c.Id == id))!=null){
            return Repositorio.GetPoliza(id);
       }else throw new Exception($" poliza no existe = {id}");
       
   }
}