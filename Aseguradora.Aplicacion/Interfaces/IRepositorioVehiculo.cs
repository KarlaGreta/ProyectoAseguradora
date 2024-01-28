namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public interface IRepositorioVehiculo{

    void AgregarVehiculo(Vehiculo vehiculo);
    void ModificarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    List<Vehiculo> ListarVehiculos();
    Vehiculo? GetVehiculo(int id);
}