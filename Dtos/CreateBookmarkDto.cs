using System.ComponentModel.DataAnnotations;

namespace Stash.Dtos;

public class CreateBookmarkDto
{
    [Required]
    public string Url { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
}
