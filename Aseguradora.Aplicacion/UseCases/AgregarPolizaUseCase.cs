using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class AgregarPolizaUseCase : PolizaUseCaseCase
{
    public AgregarPolizaUseCase(IRepositorioPoliza repositorio) : base(repositorio)
    {
    }

    public void Ejecutar(Poliza poliza)
    {
        try
        {
            
            if ((Repositorio.ListarPolizas() == null) | !(Repositorio.ListarPolizas().Any(x => x.VehiculoId == poliza.VehiculoId)))
                Repositorio.AgregarPoliza(poliza);
            else
                throw new Exception($"Ya existe una poliza para el vehiculo = {poliza.VehiculoId}");
        }
        catch (Exception e)
        {
            throw e;
        }



    }
}