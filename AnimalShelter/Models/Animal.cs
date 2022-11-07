using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  { 
      public int AnimalId { get; set; }
      [Required]
      public string AnimalName { get; set; }
      [Required]
      public string AnimalSpecies { get; set; }
      [Required]
      public int AnimalAge { get; set; }
    }
  }