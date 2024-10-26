
using API.Extensions;

namespace API.Entities;


public class Answer
{
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; } // Navigation property
    public string? TextAnswer { get; set; } // For free text answers
    public int? SelectedOptionId { get; set; } // For multiple choice answers
    public AnswerOption? SelectedOption { get; set; } // Navigation to the selected option
    public decimal? NumberAnswer { get; set; } // For numeric answers
}