using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ListarPolizaUseCase : PolizaUseCaseCase
{
   public ListarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
   {
   }

   public List<Poliza> Ejecutar()
   {
       return Repositorio.ListarPolizas();
   }
}