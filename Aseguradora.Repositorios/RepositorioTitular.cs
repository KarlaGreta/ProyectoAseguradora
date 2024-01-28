using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;

public class RepositorioTitular : IRepositorioTitular
{

    static int s_proximoId = 0;
    //int dni,string? apellido,string? nombre

    private Titular Clonar(Titular dato)
    {

        return new Titular()
        {
            Id = dato.Id,
            DNI = dato.DNI,
            Apellido = dato.Apellido,
            Nombre = dato.Nombre,
            Telefono = dato.Telefono,
            Email = dato.Email,
            Direccion = dato.Direccion
        };
    }

    public void AgregarTitular(Titular poliza)
    {
        using (var db = new AseguradoraContext())
        {
            poliza.Id = s_proximoId++;
            db.Add(poliza);
            db.SaveChanges();
        }
    }

    public void ModificarTitular(Titular titular)
    {
        using (var db = new AseguradoraContext())
        {
            var tit = db.titulares.Where(x => x.Id == (titular.Id)).SingleOrDefault();
            if (tit != null)
            {
                tit.DNI = titular.DNI;
                tit.Apellido = titular.Apellido;
                tit.Nombre = titular.Nombre;
                tit.Telefono = titular.Telefono;
                tit.Email = titular.Email;
                tit.Direccion = titular.Direccion;
                db.SaveChanges();
            }
        }
    }

    public void EliminarTitular(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var titular = db.titulares.ToList().Single(c => c.Id == id);
            db.Remove(titular);
            db.SaveChanges();
        }

    }

    public List<Titular> ListarTitulares()
    {

        List<Titular>? Lista = new List<Titular>();
        using (var db = new AseguradoraContext())
        {
            foreach (var x in db.titulares) Lista.Add(Clonar(x));
        }
        return Lista;
    }


    public Titular? GetTitular(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var p = db.titulares.Where(c => c.Id == id).Single();
            return Clonar(p);
        }
    }

    public List<TitularVehiculos> ListarTitularesConVehiculos()
    {
        List<TitularVehiculos> lista2 = new List<TitularVehiculos>();
        using (var db = new AseguradoraContext())
        {
            foreach (var x in db.titulares)
            {

                TitularVehiculos lista = new TitularVehiculos
                {
                    Id = x.Id,
                    DNI = x.DNI,
                    Apellido = x.Apellido,
                    Email=x.Email,
                    Direccion=x.Direccion,
                    vehiculos = new List<Vehiculo>()
                };

                foreach (var y in db.vehiculos)
                {
                    if (y.TitularId == lista.Id)
                    {
                        lista.vehiculos.Add(y);
                    }
                }
                lista2.Add(lista);
            }
        }
        return lista2;
    }

}
