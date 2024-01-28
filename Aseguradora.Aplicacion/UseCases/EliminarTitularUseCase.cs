using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class EliminarTitularUseCase : TitularUseCase
{
   public EliminarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {
   }

   public void Ejecutar(int id)
   {
       if ((Repositorio.ListarTitulares().Where(x=>x.Id == id).SingleOrDefault())!=null)
            Repositorio.EliminarTitular(id);
            
        else  throw new Exception($"No existe un titular con id = {id}");

   }
} 