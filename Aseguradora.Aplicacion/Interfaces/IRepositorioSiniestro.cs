namespace Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public interface IRepositorioSiniestro{

    void AgregarSiniestro(Siniestro siniestro);
    void ModificarSiniestro(Siniestro siniestro);
    void EliminarSiniestro(int id);
    List<Siniestro> ListarSiniestros();
    Siniestro? GetSiniestro(int id);
}