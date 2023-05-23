using Microsoft.AspNetCore.Mvc;
using Visitas_residenciales.Models;
using Visitas_residenciales.Services;

namespace Visitas_residenciales.Controllers;


//atributos controller

[ApiController]
[Route ("aapi/[Controller]")]
public class CasaController: ControllerBase{
    //inyeccion de dependencia

ICasaService casaService;
public CasaController(ICasaService serviceCasa){
    casaService=serviceCasa;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] Casa nuevo){
casaService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(casaService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizar([FromBody] Casa Actualizar, Guid id){
casaService.actualizar(id,Actualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
casaService.eliminar(id);
    return Ok();
}

}