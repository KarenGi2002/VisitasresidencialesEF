
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Visitas_residenciales.Models;
public class Casa{
[Key]
    public Guid casaId{get;set;}
    [Required]
[MaxLength(20)]
    public int numero{get;set;}
[MaxLength(20)]
    public int bloque{get;set;}
[MaxLength(100)]
    public int calle{get;set;}

[MaxLength(250)]
    public String? referencia{get;set;}

[ForeignKey("visitaId")]
public Guid visitaId{get;set;}
public virtual ICollection <Visita>? Visita{get;set;}
}