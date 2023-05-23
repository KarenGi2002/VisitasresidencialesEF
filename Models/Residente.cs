
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Visitas_residenciales.Models;
public class Residente{
[Key]
    public Guid residenteId{get;set;}
[Required]
[MaxLength(15)]
    public int identificacion{get;set;}
[Required]
[MaxLength(100)]
    public String? nombre{get;set;}
[Required]

    public int telefono{get;set;}
}