
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Visitas_residenciales.Models;

public class habitantesCasa{
[Key]
public Guid id{get;set;}
[Required]
[MaxLength(100)]
public String? parentesco{get;set;}

//[ForeignKey("CasaId")]
//public Guid casaId{get;set;}=Guid.NewGuid();
//public virtual Casa? Casa{get;set}

//[ForeignKey("residenteId")]
//public Guid residenteId{get;set;}=Guid.NewGuid();
//public virtual residente? residente{get;set}


}