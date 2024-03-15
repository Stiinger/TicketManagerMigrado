using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Sistemas
{
    [Key]
    public int SistemaId { get; set; }

    [Required(ErrorMessage = "Campo requerido.")]
    public string Nombre { get; set; } = string.Empty;
}