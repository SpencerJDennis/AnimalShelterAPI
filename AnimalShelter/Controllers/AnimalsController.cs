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
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

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
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, string name, int animalAge)
    {
      var query = _db.Animals.AsQueryable();

      if (animalName != null)
      {
        query = query.Where(entry => entry.AnimalName == animalName);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (team != null)
      {
        query = query.Where(entry => entry.Team == team);
      }
      
      var playerList = query.ToList();
      foreach(Player player in playerList)
      {
        var PlayerPositionDTO = new PlayerPositionDTO() { FirstName = player.FirstName , LastName = player.LastName, Team = player.Team}; 
        var PlayerPositionList = new List<string>(){};
        foreach(PlayerPosition join in player.JoinEntities)
        {
          var position = join.Position.PositionName;
          PlayerPositionList.Add(position);
        }
        PlayerPositionDTO.PositionName = PlayerPositionList;
        playerPosition.Add(PlayerPositionDTO);
      }

      return playerPosition;
    }

    // POST api/players
    [HttpPost]
    public async Task<ActionResult<Player>> Post(Player player)
    {
      _db.Players.Add(player);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(Player), new { id = player.PlayerId }, player);
    }

    // PUT: api/Players/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Player player)
    {
      if (id != player.PlayerId)
      {
        return BadRequest();
      }

      _db.Entry(player).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PlayerExists(id))
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
    private bool PlayerExists(int id)
    {
      return _db.Players.Any(e => e.PlayerId == id);
    }

    // DELETE: api/Players/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlayer(int id)
    {
      var player = await _db.Players.FindAsync(id);
      if (player == null)
      {
        return NotFound();
      }

      _db.Players.Remove(player);
      await _db.SaveChangesAsync();

      return NoContent();
    } 
  }
}