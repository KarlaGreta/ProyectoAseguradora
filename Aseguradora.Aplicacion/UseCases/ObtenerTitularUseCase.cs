using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ObtenerTitularUseCase : TitularUseCase
{
   public ObtenerTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {
   }

   public Titular? Ejecutar(int id)
   {
       if( (Repositorio.ListarTitulares().SingleOrDefault(c => c.Id == id))!=null){
            return Repositorio.GetTitular(id);
       }else throw new Exception($" titular no existe = {id}");
       
   }
}