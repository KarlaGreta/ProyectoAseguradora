using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ModificarTitularUseCase : TitularUseCase
{
   public ModificarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {      
   }

   public void Ejecutar(Titular titular)
   {
       if ((Repositorio.ListarTitulares().Where(x=>x.Id== titular.Id).SingleOrDefault())!=null){
            Repositorio.ModificarTitular(titular);
       }            
        else  throw new Exception($"error al modificar titular = {titular.Id}");
   }
}