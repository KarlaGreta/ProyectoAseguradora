using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;


public class ListarTitularesConSusVehiculosUseCase : TitularUseCase
{
   public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repositorio) : base(repositorio)
   {
   }


   public List<TitularVehiculos> Ejecutar()
   {
       return Repositorio.ListarTitularesConVehiculos();
   }
}