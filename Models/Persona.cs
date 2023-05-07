using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using agenda.Models;

namespace agenda.Models;


public class Persona{
[Key]
public Guid PersonaId{get;set;}
[Required]
[MaxLength]
public string ?Nombre{get;set;} 
[Required]
[MaxLength(50)]
public string ?Apellido{get;set;}
[MaxLength(50)]
public string ?Alias{get;set;}

public DateTime FechaN{get;set;}

public Sexo Sexo{get;set;}

public EstadoCivil estadiCivil{get;set;}

public string? correo{get;set;}

public virtual ICollection<Telefono>? Telefonos {get;set;}

[NotMapped]
public int Edad{get;set;}
}
public enum Sexo{
    
    Masculino,
    Femenino,
    NoEspecificar
}

public enum EstadoCivil{
    Soltero,
    Casado,
    Viudo,
    Divorciado,
    UnionLibre
}