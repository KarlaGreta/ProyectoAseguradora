using Microsoft.EntityFrameworkCore;
using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Repositorios;

public class AseguradoraContext:DbContext{

    #nullable disable
    public DbSet<Poliza> polizas{get;set;}
    public DbSet<Vehiculo> vehiculos{get;set;}
    public DbSet<Titular> titulares{get;set;}
    public DbSet<Siniestro> siniestros{get;set;}
    public DbSet<Tercero> terceros{get;set;}
    #nullable restore

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}