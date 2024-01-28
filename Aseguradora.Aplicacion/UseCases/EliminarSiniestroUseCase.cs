using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class EliminarSiniestroUseCase : SiniestroUseCase
{
   public EliminarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
   {
   }

   public void Ejecutar(int id)
   {
       if ((Repositorio.ListarSiniestros().Where(x=>x.Id == id).SingleOrDefault())!=null)
            Repositorio.EliminarSiniestro(id);
            
        else  throw new Exception($"No existe un siniestro con id = {id}");

   }
}