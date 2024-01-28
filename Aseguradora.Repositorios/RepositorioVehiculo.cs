using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;

public class RepositorioVehiculo : IRepositorioVehiculo
{

    static int s_proximoId = 0;

    private Vehiculo Clonar(Vehiculo v)
    {

        return new Vehiculo()
        {
            Id = v.Id,
            Dominio = v.Dominio,
            Marca = v.Marca,
            Anio = v.Anio,
            TitularId = v.TitularId
        };
    }

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        
            using (var db = new AseguradoraContext())
            {
                    vehiculo.Id = s_proximoId++;
                    db.Add(vehiculo);
                    db.SaveChanges();
                }
               
       

    }

    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            var veh = db.vehiculos.Where(x => x.Id == (vehiculo.Id)).SingleOrDefault();
            if (veh != null)
            {
                veh.Dominio = vehiculo.Dominio;
                veh.Marca = vehiculo.Marca;
                veh.Anio = vehiculo.Anio;
                veh.TitularId = vehiculo.TitularId;
                db.SaveChanges();
            }
        }
    }

    public void EliminarVehiculo(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var vehiculo = db.vehiculos.ToList().Single(c => c.Id == id);
            db.Remove(vehiculo);
            db.SaveChanges();
        }

    }

    public List<Vehiculo> ListarVehiculos()
    {

        List<Vehiculo>? Lista = new List<Vehiculo>();
        using (var db = new AseguradoraContext())
        {
            foreach (var x in db.vehiculos) Lista.Add(Clonar(x));
        }
        return Lista;
    }


    public Vehiculo? GetVehiculo(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var p = db.vehiculos.Where(c => c.Id == id).Single();
            return Clonar(p);
        }
    }
}
