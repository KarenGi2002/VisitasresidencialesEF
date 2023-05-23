using Microsoft.AspNetCore.Mvc;
using Visitas_residenciales.Models;
using Visitas_residenciales.Services;

namespace Visitas_residenciales.Controllers;


//atributos controller

[ApiController]
[Route ("aapi/[Controller]")]
public class ResidenteController: ControllerBase{
    //inyeccion de dependencia

IResidenteService rService;
public ResidenteController(IResidenteService servicer){
    rService=servicer;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] Residente nuevo){
rService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(rService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] Residente Actualizar, Guid id){
rService.actualizar(id,Actualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
rService.eliminar(id);
    return Ok();
}

}