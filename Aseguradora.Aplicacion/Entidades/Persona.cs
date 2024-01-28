namespace   Aseguradora.Aplicacion.Entidades;

public abstract class Persona{

    //private static int cont;
    public int Id{get;set;}
    public int DNI{get;set;}
    public string? Apellido{get;set;}
    public string? Nombre{get;set;}
    public int? Telefono{get;set;}


    /* public Persona(int dni,string? apellido,string? nombre,int? telefono){
        DNI=dni;
        Apellido=apellido;
        Nombre=nombre;
        Telefono=telefono;
        //Id=-(cont+1);
    } */
    public Persona(){}

    /* public void actualizaCont(){
        cont++;
        Id=cont;
    }
    public static void iniciarCont(){
        cont=0;
    }
    public static void ActualizarCont(int aux){cont=aux;}
    
    public override string ToString(){
        return $" {Id}: {DNI} {Apellido}, {Nombre}";
    } */
    
}