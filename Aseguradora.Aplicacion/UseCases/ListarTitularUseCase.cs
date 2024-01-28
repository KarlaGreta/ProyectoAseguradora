using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ListarTitularUseCase : TitularUseCase
{
   public ListarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {
   }

   public List<Titular> Ejecutar()
   {
       return Repositorio.ListarTitulares();
   }
}