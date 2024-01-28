using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ModificarPolizaUseCase : PolizaUseCaseCase
{
   public ModificarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   {      
   }

   public void Ejecutar(Poliza poliza)
   {
       if ((Repositorio.ListarPolizas().Where(x=>x.Id== poliza.Id).SingleOrDefault())!=null){
            Repositorio.ModificarPoliza(poliza);
       }            
        else  throw new Exception($"error al modificar poliza = {poliza.Id}");
   }
}