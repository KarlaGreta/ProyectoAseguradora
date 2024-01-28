namespace   Aseguradora.Aplicacion.Entidades;

public  class Siniestro{

    public int Id{get;set;}
    public int PolizaId{get;set;}
    public DateTime ingreso{get;set;}
    public string? ocurrencia{get;set;}
    public string? direccion{get;set;}
    public string? descripcion{get;set;}
    
}