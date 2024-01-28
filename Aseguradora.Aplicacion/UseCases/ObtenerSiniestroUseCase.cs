using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ObtenerSiniestroUseCase : SiniestroUseCase
{
   public ObtenerSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
   {
   }

   public Siniestro? Ejecutar(int id)
   {
       if( (Repositorio.ListarSiniestros().SingleOrDefault(c => c.Id == id))!=null){
            return Repositorio.GetSiniestro(id);
       }else throw new Exception($" Siniestro no existe = {id}");
       
   }
}