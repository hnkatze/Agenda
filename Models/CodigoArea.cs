using agenda.Models;
using System.ComponentModel.DataAnnotations;
namespace agenda.Models;

public class CodigoArea{
[Key]
public Guid CodigoAreaId{get;set;}
[Required]
public int Numero {get; set;}

[MaxLength(50)]
[Required]
public string ?Pais {get;set;}
public virtual ICollection<Telefono> ?Telefonos {get;set;}
 
}