using API.Extensions;

namespace API.Entities;

public class Questionnaire
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public List<QuestionSection> Sections { get; set; } = new(); // New list of sections
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; } = null!;
}