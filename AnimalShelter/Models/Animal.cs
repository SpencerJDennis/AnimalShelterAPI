using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public Animal()
    {
    
      public int AnimalId { get; set; }
      [Required]
      public string AnimalName { get; set; }
      [Required]
      public string AnimalSpecies { get; set; }
      [Required]
      public string AnimalAge { get; set; }
    }
  }
}