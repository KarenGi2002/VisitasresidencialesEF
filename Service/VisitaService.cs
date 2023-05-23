using Visitas_residenciales.Models;
namespace Visitas_residenciales.Services;

public class VisitaService: IVisitaService{
    //inyeccion de dependencia a la base de datos
VisitasContext context;

public VisitaService(VisitasContext dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(Visita input){
        input.visitaId=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <Visita>? obtener(){
        return context.Visita;
    }
    public async Task actualizar (Guid id, Visita input){
        var c=  context.Visita?.Find(id);

        if(c != null){
            c.estado=input.estado;
            c.fechaEntrada=input.fechaEntrada;
            c.fechaSalida=input.fechaSalida;
            c.CodigoQR=input.CodigoQR;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var c=context.Visita?.Find(id);
        if(c != null){
            context.Remove(c);
            await context.SaveChangesAsync();
        }
    }
}

public interface IVisitaService{
    Task insertar (Visita input);
    IEnumerable<Visita>? obtener();
    Task actualizar(Guid id, Visita input);
    Task eliminar(Guid id);
}