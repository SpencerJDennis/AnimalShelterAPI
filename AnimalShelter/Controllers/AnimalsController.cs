using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using AnimalShelter.Repository;

namespace AnimalShelter.Controllers
{
  //[Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    private readonly IJWTManagerRepository _jWTManager;
	  public AnimalsController(IJWTManagerRepository jWTManager, AnimalShelterContext db)
    {
      this._jWTManager = jWTManager;
      _db = db;
    }

    
    [HttpPost]
    [Route("authenticate")]
    public IActionResult Authenticate(Users usersdata)
    {
      var token = _jWTManager.Authenticate(usersdata);

      if (token == null)
      {
        return Unauthorized();
      }

      return Ok(token);
    }

    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string animalSpecies, string animalName, int animalAge)
    {
      var query = _db.Animals.AsQueryable();

      if (animalName != null)
      {
        query = query.Where(entry => entry.AnimalName == animalName);
      }

      if (animalSpecies != null)
      {
        query = query.Where(entry => entry.AnimalSpecies == animalSpecies);
      }

      if (animalAge > 0)
      {
        query = query.Where(entry => entry.AnimalAge == animalAge);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = animal.AnimalId }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    } 
  }
}