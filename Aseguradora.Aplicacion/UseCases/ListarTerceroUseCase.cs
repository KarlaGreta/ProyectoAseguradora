using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ListarTerceroUseCase : TerceroUseCase
{
   public ListarTerceroUseCase(IRepositorioTercero repositorio) : base(repositorio)
   {
   }

   public List<Tercero> Ejecutar()
   {
       return Repositorio.ListarTerceros();
   }
}