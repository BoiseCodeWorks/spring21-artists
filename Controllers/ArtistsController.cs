using System;
using System.Collections.Generic;
using artgallery.Models;
using artgallery.Services;
using Microsoft.AspNetCore.Mvc;

namespace artgallery.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ArtistsController : ControllerBase
  {
    private readonly ArtistsService _service;

    public ArtistsController(ArtistsService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Artist>> GetAll()
    {
      try
      {
        IEnumerable<Artist> artists = _service.GetAll();
        return Ok(artists);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Artist> GetById(int id)
    {
      try
      {
        Artist artist = _service.GetById(id);
        return Ok(artist);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Artist> Create([FromBody] Artist newArtist)
    {
      try
      {
        Artist artist = _service.Create(newArtist);
        return Ok(artist);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpPut("{id}")]
    public ActionResult<Artist> Update(int id, [FromBody] Artist update)
    {
      try
      {
        update.Id = id;
        Artist updated = _service.Update(update);
        return Ok(updated);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> DeleteArtist(int id)
    {
      try
      {
        _service.DeleteArtist(id);
        return Ok("Delorted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }



  }
}