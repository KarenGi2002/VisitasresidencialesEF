using Visitas_residenciales.Models;
namespace Visitas_residenciales.Services;

public class CasaService: ICasaService{
    //inyeccion de dependencia a la base de datos
VisitasContext context;

public CasaService(VisitasContext dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(Casa input){
        input.casaId=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <Casa>? obtener(){
        return context.Casa;
    }
    public async Task actualizar (Guid id, Casa input){
        var c=  context.Casa?.Find(id);

        if(c != null){
            c.numero=input.numero;
            c.bloque= input.bloque;
            c.calle= input.calle;
            c.referencia=input.referencia;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var c=context.Casa?.Find(id);
        if(c != null){
            context.Remove(c);
            await context.SaveChangesAsync();
        }
    }
}

public interface ICasaService{
    Task insertar (Casa inputCargo);
    IEnumerable<Casa>? obtener();
    Task actualizar(Guid id, Casa input);
    Task eliminar(Guid id);
}