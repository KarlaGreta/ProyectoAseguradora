namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public interface IRepositorioTitular{

    void AgregarTitular(Titular titular);
    void ModificarTitular(Titular titular);
    void EliminarTitular(int id);
    List<Titular> ListarTitulares();
    Titular? GetTitular(int id);
    List<TitularVehiculos> ListarTitularesConVehiculos();
}