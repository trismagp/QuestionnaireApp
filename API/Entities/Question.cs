using API.Extensions;

namespace API.Entities;


public class Question
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public QuestionType Type { get; set; }
    public List<AnswerOption>? AnswerOptions { get; set; } = new();
    public bool IsRequired { get; set; }
}