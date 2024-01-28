using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;

public class RepositorioTercero:IRepositorioTercero{

    static int s_proximoId = 0;

    private Tercero Clonar(Tercero dato){

        return new Tercero(){
            Id=dato.Id,
            DNI=dato.DNI,
            Apellido=dato.Apellido,
            Nombre=dato.Nombre,
            Telefono=dato.Telefono,
            nombreAseguradora=dato.nombreAseguradora,
            SiniestroId=dato.SiniestroId
        };
    }

    public void AgregarTercero(Tercero tercero){
        try{
            using( var db= new AseguradoraContext()){
            if(db.siniestros.SingleOrDefault(x=>x.Id==tercero.SiniestroId)!= null){
                tercero.Id = s_proximoId++;
                db.Add(tercero);
                db.SaveChanges();
            }else throw new Exception ("No existe el siniestro ");
        }
        }catch(Exception e){
            throw e;
        }
        
    }

    public void ModificarTercero(Tercero dato){
        using( var db= new AseguradoraContext()){
            var sis= db.terceros.Where(x=>x.Id== (dato.Id)).SingleOrDefault();
            if( sis != null){
                sis.Id=dato.Id;
                sis.DNI=dato.DNI;
                sis.Apellido=dato.Apellido;
                sis.Nombre=dato.Nombre;
                sis.Telefono=dato.Telefono;
                sis.nombreAseguradora=dato.nombreAseguradora;
                sis.SiniestroId=dato.SiniestroId;
                db.SaveChanges();
            }         
        }
    }

    public void EliminarTercero(int id){
        using( var db= new AseguradoraContext()){
            var tercero = db.terceros.ToList().Single(c => c.Id == id);
                db.Remove(tercero);
                db.SaveChanges(); 
        }

    }

    public List<Tercero> ListarTerceros(){
        
        List<Tercero>? Lista=new List<Tercero>();
        using( var db= new AseguradoraContext()){           
                foreach(var x in db.terceros)   Lista.Add(Clonar(x));
            }
              return Lista;
        }
    
    
    public Tercero? GetTercero(int id){
        using( var db= new AseguradoraContext()){
             var s= db.terceros.Where(c=>c.Id==id).Single();
             return Clonar(s);
        }
    }
}