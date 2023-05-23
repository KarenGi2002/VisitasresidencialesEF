using Microsoft.AspNetCore.Mvc;
using Visitas_residenciales.Models;
using Visitas_residenciales.Services;

namespace Visitas_residenciales.Controllers;


//atributos controller

[ApiController]
[Route ("aapi/[Controller]")]
public class HabitantesController: ControllerBase{
    //inyeccion de dependencia

IHabitantesService hService;
public HabitantesController(IHabitantesService serviceh){
    hService=serviceh;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] habitantesCasa nuevo){
hService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(hService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] habitantesCasa Actualizar, Guid id){
hService.actualizar(id,Actualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
hService.eliminar(id);
    return Ok();
}

}