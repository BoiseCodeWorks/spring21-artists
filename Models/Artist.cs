using System.ComponentModel.DataAnnotations;

namespace artgallery.Models
{
  public class Artist
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int BirthYear { get; set; }
    public int DeathYear { get; set; }
    public int AgeAtDeath { get { return DeathYear - BirthYear; } }
  }
}