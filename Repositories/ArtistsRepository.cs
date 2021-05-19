using System;
using System.Collections.Generic;
using System.Data;
using artgallery.Models;
using Dapper;

namespace artgallery.Repositories
{
  public class ArtistsRepository
  {
    private readonly IDbConnection _db;
    public ArtistsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Artist> GetAll()
    {
      string sql = "SELECT * FROM artists";
      // QUERY returns a collection
      return _db.Query<Artist>(sql);
    }

    internal Artist GetById(int id)
    {
      // Dapper uses '@' to indicate a variable that can be safeley injectected in the Query arguments
      string sql = "SELECT * FROM artists WHERE id = @id";
      //   Query first or default returns a single item or null
      return _db.QueryFirstOrDefault<Artist>(sql, new { id });
    }

    internal Artist Create(Artist newArtist)
    {
      string sql = @"
        INSERT INTO artists
        (name, birthyear, deathyear)
        VALUES
        (@Name, @BirthYear, @DeathYear);
        SELECT LAST_INSERT_ID()";

      newArtist.Id = _db.ExecuteScalar<int>(sql, newArtist);
      return newArtist;
    }

    internal bool Update(Artist original)
    {
      string sql = @"
      UPDATE artists
      SET
        name = @Name,
        birthyear = @BirthYear,
        deathyear = @DeathYear
      WHERE id=@Id
      ";
      int affectedRows = _db.Execute(sql, original);
      return affectedRows == 1;
    }

    internal bool Delete(int id)
    {
      // Dapper uses '@' to indicate a variable that can be safeley injectected in the Query arguments
      string sql = "DELETE FROM artists WHERE id = @id LIMIT 1";
      //   Query first or default returns a single item or null
      int affectedRows = _db.Execute(sql, new { id });
      return affectedRows == 1;
    }
  }
}