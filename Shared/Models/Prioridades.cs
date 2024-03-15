﻿using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Prioridades
{
    [Key]
    public int PrioridadId { get; set; }
    [Required(ErrorMessage = "El campo Descripción no puede estar vacío.")]
    public string? Descripcion { get; set; }
    [Required(ErrorMessage = "Campo Requerido.")]
    [Range(1, 31, ErrorMessage = "Debe ingresar valores entre 1 y 31.")]
    public int? DiasCompromiso { get; set; }
}