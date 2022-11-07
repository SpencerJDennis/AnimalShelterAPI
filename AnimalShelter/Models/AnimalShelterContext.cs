using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, AnimalName = "Fido", AnimalSpecies = "Dog", AnimalAge = 2},
          new Animal { AnimalId = 2, AnimalName = "Amber", AnimalSpecies = "Cat", AnimalAge = 15},
          new Animal { AnimalId = 3, AnimalName = "Tilly", AnimalSpecies = "Dog", AnimalAge = 10},
          new Animal { AnimalId = 4, AnimalName = "Tobby", AnimalSpecies = "Dog", AnimalAge = 10},
          new Animal { AnimalId = 5, AnimalName = "Rocky", AnimalSpecies = "Dog", AnimalAge = 6},
          new Animal { AnimalId = 6, AnimalName = "Pudgey", AnimalSpecies = "Cat", AnimalAge = 9},
          new Animal { AnimalId = 7, AnimalName = "Niki", AnimalSpecies = "Cat", AnimalAge = 1},
          new Animal { AnimalId = 8, AnimalName = "Memo", AnimalSpecies = "Cat", AnimalAge = 2},
          new Animal { AnimalId = 9, AnimalName = "Late", AnimalSpecies = "Cat", AnimalAge = 3},
          new Animal { AnimalId = 10, AnimalName = "Jack", AnimalSpecies = "Dog", AnimalAge = 5}
        );
    }
  }
}