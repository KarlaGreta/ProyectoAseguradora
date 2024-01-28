using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class ListarSiniestroUseCase : SiniestroUseCase
{
   public ListarSiniestroUseCase(IRepositorioSiniestro repositorio) : base(repositorio)
   {
   }

   public List<Siniestro> Ejecutar()
   {
       return Repositorio.ListarSiniestros();
   }
}