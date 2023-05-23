
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Visitas_residenciales.Models;
public class Visita{

    public Guid visitaId{get;set;}
[MaxLength(20)]
    public string? fechaEntrada{get;set;}
[MaxLength(20)]

public string? fechaSalida{get;set;}
public string? CodigoQR{get;set;}

public bool estado{get;set;}

[ForeignKey("casaId")]
public Guid casaId{get;set;} = Guid.NewGuid();
public virtual ICollection <Casa>? Casa{get;set;}

[ForeignKey("VisitanteId")]
public Guid VisitanteId{get;set;} = Guid.NewGuid();
public virtual ICollection <Visitante>? Visitante{get;set;}

    
    
    
       }
