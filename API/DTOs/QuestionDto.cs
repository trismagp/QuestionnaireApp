using API.Entities;

namespace API.DTOs;
public class QuestionDto
{
    public int Id { get; set; }
    public string Text { get; set; }
    public QuestionType Type { get; set; }
    public List<AnswerOptionDto>? AnswerOptions { get; set; } = new();
    public List<FreeTextFieldDto>? FreeTextFields { get; set; } = new(); // For MultipleFreeText
    public bool IsRequired { get; set; }
}