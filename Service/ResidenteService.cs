using Visitas_residenciales.Models;
namespace Visitas_residenciales.Services;

public class ResidenteService: IResidenteService{
    //inyeccion de dependencia a la base de datos
VisitasContext context;

public ResidenteService(VisitasContext dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(Residente input){
        input.residenteId=Guid.NewGuid();
        await context.AddAsync(input);
        await context.SaveChangesAsync();
    }

    public IEnumerable <Residente>? obtener(){
        return context.Residente;
    }
    public async Task actualizar (Guid id, Residente input){
        var c=  context.Residente?.Find(id);

        if(c != null){
            c.nombre=input.nombre;
            c.identificacion=input.identificacion;
            c.telefono=input.telefono;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var c=context.Residente?.Find(id);
        if(c != null){
            context.Remove(c);
            await context.SaveChangesAsync();
        }
    }
}

public interface IResidenteService{
    Task insertar (Residente input);
    IEnumerable<Residente>? obtener();
    Task actualizar(Guid id, Residente input);
    Task eliminar(Guid id);
}