using System.ComponentModel.DataAnnotations;

namespace ClientesRJRL.Models;

public class Clientes{

    [Key]
    public int ClienteId {get; set;}

    [Required (ErrorMessage = "Debe de insertar un nombre")]
    public string? Nombre{get; set;}

    [Required(ErrorMessage ="Debe de insertar un numero telefonico")]
    public string? Telefono{get; set;}

    [Required(ErrorMessage ="Debe de insertar un numero de celular")]
    public string? Celular{get; set;}

    [Required(ErrorMessage ="Debe de insertar un RNC")]
    public string? Rnc{get; set;}

    [Required(ErrorMessage ="Debe de insertar un email valido")]
    public string? Email{get; set;}

    [Required(ErrorMessage ="Debe de insertar una direccion")]
    public string? Direccion{get; set;}
}