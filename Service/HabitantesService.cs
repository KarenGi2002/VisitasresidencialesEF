using Visitas_residenciales.Models;
namespace Visitas_residenciales.Services;

public class HabitantesService: IHabitantesService{
    //inyeccion de dependencia a la base de datos
VisitasContext context;

public HabitantesService(VisitasContext dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(habitantesCasa input){
        input.id=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <habitantesCasa>? obtener(){
        return context.habitantesCasa;
    }
    public async Task actualizar (Guid id, habitantesCasa input){
        var c=  context.habitantesCasa?.Find(id);

        if(c != null){
            c.parentesco=input.parentesco;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var c=context.habitantesCasa?.Find(id);
        if(c != null){
            context.Remove(c);
            await context.SaveChangesAsync();
        }
    }
}

public interface IHabitantesService{
    Task insertar (habitantesCasa input);
    IEnumerable<habitantesCasa>? obtener();
    Task actualizar(Guid id, habitantesCasa input);
    Task eliminar(Guid id);
}