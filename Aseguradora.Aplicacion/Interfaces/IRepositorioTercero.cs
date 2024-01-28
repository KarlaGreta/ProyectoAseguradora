namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public interface IRepositorioTercero{

    void AgregarTercero(Tercero tercero);
    void ModificarTercero(Tercero tercero);
    void EliminarTercero(int id);
    List<Tercero> ListarTerceros();
    Tercero? GetTercero(int id);
}