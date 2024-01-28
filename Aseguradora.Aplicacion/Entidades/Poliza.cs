namespace   Aseguradora.Aplicacion.Entidades;

public  class Poliza{

    public int Id{get;set;}
    public int VehiculoId{get;set;}
    public double valor{get;set;}
    public string? franquicia{get;set;}
    public string? cobertura{get;set;}
    public DateTime? Inicio{get;set;}
    public DateTime? Fin{get;set;}
  
}