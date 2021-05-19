using System;
using System.Collections.Generic;
using artgallery.Models;
using artgallery.Repositories;

namespace artgallery.Services
{
  public class ArtistsService
  {
    private readonly ArtistsRepository _repo;

    public ArtistsService(ArtistsRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Artist> GetAll()
    {
      return _repo.GetAll();
    }

    internal Artist GetById(int id)
    {
      Artist artist = _repo.GetById(id);
      if (artist == null)
      {
        throw new Exception("Invalid Id");
      }
      return artist;
    }

    internal Artist Create(Artist newArtist)
    {
      Artist artist = _repo.Create(newArtist);
      return artist;
    }

    internal Artist Update(Artist update)
    {
      Artist original = GetById(update.Id);
      original.Name = update.Name.Length > 0 ? update.Name : original.Name;
      original.BirthYear = update.BirthYear > 0 ? update.BirthYear : original.BirthYear;
      original.DeathYear = update.DeathYear > 0 ? update.DeathYear : original.DeathYear;
      if (_repo.Update(original))
      {
        return original;
      }
      throw new Exception("Something Went Wrong???");
    }

    internal void DeleteArtist(int id)
    {
      GetById(id);
      _repo.Delete(id);
    }
  }
}