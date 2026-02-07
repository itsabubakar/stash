namespace Stash.Dtos;

public class CreateBookmarkDto
{
    public string Url { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
}
