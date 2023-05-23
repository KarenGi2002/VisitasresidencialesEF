using Microsoft.AspNetCore.Mvc;
using Visitas_residenciales.Models;
using Visitas_residenciales.Services;

namespace Visitas_residenciales.Controllers;


//atributos controller

[ApiController]
[Route ("aapi/[Controller]")]
public class VisitanteController: ControllerBase{
    //inyeccion de dependencia

IVisitanteService vService;
public VisitanteController(IVisitanteService servicev){
    vService=servicev;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] Visitante nuevo){
vService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(vService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] Visitante Actualizar, Guid id){
vService.actualizar(id,Actualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
vService.eliminar(id);
    return Ok();
}

}