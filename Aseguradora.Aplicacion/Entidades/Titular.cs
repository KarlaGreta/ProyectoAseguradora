namespace   Aseguradora.Aplicacion.Entidades;
public class Titular:Persona {

    public string? Email{get;set;}
    public string? Direccion{get;set;}

    //public List<Vehiculo>? vehiculos{get;set;}


    public Titular(){}

    /* public Titular(int dni,string? apellido,string? nombre,int telefono):base(dni,apellido,nombre,telefono){
        
    } 

    public override string ToString(){
        return $" {base.ToString()} {Email} {Direccion}";
    }  */
}