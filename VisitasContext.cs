using Microsoft.EntityFrameworkCore;
using Visitas_residenciales.Models;
namespace Visitas_residenciales;


public class VisitasContext: DbContext{
public DbSet<Casa>? Casa{get;set;}

public DbSet<habitantesCasa>? habitantesCasa{get;set;}
public DbSet<Residente>? Residente{get;set;}
public DbSet<Visita>? Visita {get;set;}
public DbSet<Visitante>? Visitante{get;set;}
public VisitasContext(DbContextOptions<VisitasContext> options) : base(options){  }
}
