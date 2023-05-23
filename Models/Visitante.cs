
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Visitas_residenciales.Models;
public class Visitante
{

    public Guid visitanteId{get;set;}

    public int identificacion{get;set;}

    public String? nombre{get;set;}

    public Boolean sexo{get;set;}

    public int edad{get;set;}

}