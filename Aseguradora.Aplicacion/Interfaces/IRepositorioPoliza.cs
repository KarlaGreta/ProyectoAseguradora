namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public interface IRepositorioPoliza{

    void AgregarPoliza(Poliza poliza);
    void ModificarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
    List<Poliza> ListarPolizas();
    Poliza? GetPoliza(int id);
}