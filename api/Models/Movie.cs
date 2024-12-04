using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
}
