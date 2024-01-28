using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;

public class RepositorioSiniestro : IRepositorioSiniestro
{

    static int s_proximoId = 0;

    private Siniestro Clonar(Siniestro p)
    {

        return new Siniestro()
        {
            Id = p.Id,
            PolizaId = p.PolizaId,
            ingreso = p.ingreso,
            ocurrencia = p.ocurrencia,
            direccion = p.direccion,
            descripcion = p.descripcion,
        };
    }

    public void AgregarSiniestro(Siniestro siniestro)
    {
        using (var db = new AseguradoraContext())
        {
            var pol_act = db.polizas.SingleOrDefault(x => x.Id == siniestro.PolizaId);
            try
            {
                if ((pol_act != null))
                {

                    if ((siniestro.ingreso.CompareTo(pol_act.Fin)) == -1 && (siniestro.ingreso.CompareTo(pol_act.Inicio)) == 1)
                    {
                        siniestro.Id = s_proximoId++;
                        db.Add(siniestro);
                        db.SaveChanges();
                    }
                    else throw new Exception("la fecha de la poliza no cubre el siniestro");

                }
                else throw new Exception("no existe poliza que cubra el siniestro");
                 
            }
            catch (Exception e)
            {
                throw e;
            }


        }
    }


    public void ModificarSiniestro(Siniestro siniestro)
    {
        using (var db = new AseguradoraContext())
        {
            var sis = db.siniestros.Where(x => x.Id == (siniestro.Id)).SingleOrDefault();
            if (sis != null)
            {
                sis.PolizaId = siniestro.PolizaId;
                sis.ingreso = siniestro.ingreso;
                sis.ocurrencia = siniestro.ocurrencia;
                sis.direccion = siniestro.direccion;
                sis.descripcion = siniestro.descripcion;
                db.SaveChanges();
            }
        }
    }

    public void EliminarSiniestro(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var siniestro = db.siniestros.ToList().Single(c => c.Id == id);
            db.Remove(siniestro);
            db.SaveChanges();
        }

    }

    public List<Siniestro> ListarSiniestros()
    {

        List<Siniestro>? Lista = new List<Siniestro>();
        using (var db = new AseguradoraContext())
        {
            foreach (var x in db.siniestros) Lista.Add(Clonar(x));
        }
        return Lista;
    }


    public Siniestro? GetSiniestro(int id)
    {
        using (var db = new AseguradoraContext())
        {
            var s = db.siniestros.Where(c => c.Id == id).Single();
            return Clonar(s);
        }
    }
}



