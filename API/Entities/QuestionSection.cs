
using API.Extensions;

namespace API.Entities;


public class QuestionSection
{
    public int Id { get; set; }
    public required string Title { get; set; } // Section title (e.g., "Personal Info", "Preferences")
    public string? Description { get; set; } // Optional description of the section
    public List<Question> Questions { get; set; } = new(); // List of questions in this section
}