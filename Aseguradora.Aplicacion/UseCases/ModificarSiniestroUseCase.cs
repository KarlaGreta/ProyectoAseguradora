using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ModificarSiniestroUseCase : SiniestroUseCase
{
   public ModificarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
   {      
   }

   public void Ejecutar(Siniestro siniestro)
   {
       if ((Repositorio.ListarSiniestros().Where(x=>x.Id== siniestro.Id).SingleOrDefault())!=null){
            Repositorio.ModificarSiniestro(siniestro);
       }            
        else  throw new Exception($"error al modificar siniestro = {siniestro.Id}");
   }
}