namespace Dima.Core.Models;

public class Category : Model
{
    public string Title { get; set; } = String.Empty;
    public string? Description { get; set; } = String.Empty;
    public string UserId { get; set; } = String.Empty;
}