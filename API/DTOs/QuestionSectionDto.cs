
namespace API.DTOs;

public class QuestionSectionDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public List<QuestionDto> Questions { get; set; } = new();
}