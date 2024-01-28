using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;

public class RepositorioPoliza : IRepositorioPoliza
{

    static int s_proximoId = 0;

    private Poliza Clonar(Poliza p)
    {

        return new Poliza()
        {
            Id = p.Id,
            VehiculoId = p.VehiculoId,
            valor = p.valor,
            franquicia = p.franquicia,
            cobertura = p.cobertura,
            Inicio = p.Inicio,
            Fin = p.Fin,
        };
    }

    public void AgregarPoliza(Poliza poliza)
    {
        try
        {
            using (var db = new AseguradoraContext())
            {
                if (db.vehiculos.SingleOrDefault(x => x.Id == poliza.VehiculoId) != null)
                {
                    poliza.Id = s_proximoId++;
                    db.Add(poliza);
                    db.SaveChanges();
                }
                else throw new Exception("no existe vehiculo para agregar la poliza");
            }
        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public void ModificarPoliza(Poliza poliza)
    {
        using (var db = new AseguradoraContext())
        {
            var pol = db.polizas.Where(x => x.Id == (poliza.Id)).SingleOrDefault();
            if (pol != null)
            {
                pol.valor = poliza.valor;
                pol.franquicia = poliza.franquicia;
                pol.cobertura = poliza.cobertura;
                pol.Inicio = poliza.Inicio;
                pol.Fin = poliza.Fin;
                db.SaveChanges();
            }
        }
    }

    public void EliminarPoliza(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var poliza = db.polizas.ToList().Single(c => c.Id == id);
            db.Remove(poliza);
            db.SaveChanges();
        }

    }

    public List<Poliza> ListarPolizas()
    {

        List<Poliza>? Lista = new List<Poliza>();
        using (var db = new AseguradoraContext())
        {
            foreach (var x in db.polizas) Lista.Add(Clonar(x));
        }
        return Lista;
    }


    public Poliza? GetPoliza(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var p = db.polizas.Where(c => c.Id == id).Single();
            return Clonar(p);
        }
    }
}



