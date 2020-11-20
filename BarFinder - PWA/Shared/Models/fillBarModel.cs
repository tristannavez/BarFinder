using System;
using System.ComponentModel.DataAnnotations;

public class fillBarModel
{
    [Required(ErrorMessage = "Le champ est requis")]
    [StringLength(30, ErrorMessage = "Le nom du bar est trop long")]
    public string Identifier { get; set; }

    public string Description { get; set; }

    [Required]
    public string Classification { get; set; }

    [Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
    public int MaximumAccommodation { get; set; }

}