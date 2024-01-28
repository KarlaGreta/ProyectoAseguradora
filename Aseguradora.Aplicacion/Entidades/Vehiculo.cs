namespace   Aseguradora.Aplicacion.Entidades;

public class Vehiculo{

    //private static int cont;
    public int Id{get;set;}
    public string? Dominio{get;set;}
    public string? Marca{get;set;}
    public int Anio{get;set;}
    public int TitularId{get;set;}

    /* public void actualizaCont(){
        cont++;
        Id=cont;
    } */
}