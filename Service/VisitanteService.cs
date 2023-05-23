using Visitas_residenciales.Models;
namespace Visitas_residenciales.Services;

public class VisitanteService: IVisitanteService{
    //inyeccion de dependencia a la base de datos
VisitasContext context;

public VisitanteService(VisitasContext dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(Visitante input){
        input.visitanteId=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <Visitante>? obtener(){
        return context.Visitante;
    }
    public async Task actualizar (Guid id, Visitante input){
        var c=  context.Visitante?.Find(id);

        if(c != null){
            c.identificacion=input.identificacion;
            c.nombre=input.nombre;
            c.sexo=input.sexo;
            c.edad=input.edad;
        
            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var c=context.Visitante?.Find(id);
        if(c != null){
            context.Remove(c);
            await context.SaveChangesAsync();
        }
    }
}

public interface IVisitanteService{
    Task insertar (Visitante input);
    IEnumerable<Visitante>? obtener();
    Task actualizar(Guid id, Visitante input);
    Task eliminar(Guid id);
}