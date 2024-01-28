using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.UseCases;

public class AgregarTitularUseCase : TitularUseCase
{
    public AgregarTitularUseCase(IRepositorioTitular repositorio) : base(repositorio)
    {
    }

    public void Ejecutar(Titular titular)
    {
        try
        {
            if ((Repositorio.ListarTitulares() == null) | !(Repositorio.ListarTitulares().Any(x => x.DNI == titular.DNI)))
                Repositorio.AgregarTitular(titular);

            else throw new Exception($"Ya existe un titular con DNI = {titular.DNI}");
        }
        catch (Exception e)
        {
            throw e;
        }

    }
}