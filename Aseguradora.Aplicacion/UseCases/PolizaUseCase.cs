using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UseCases;

public abstract class PolizaUseCaseCase
{
   protected IRepositorioPoliza Repositorio { get; private set; }

   public PolizaUseCaseCase(IRepositorioPoliza repositorio)
   {
       this.Repositorio = repositorio;
   }
}