using API.Extensions;

namespace API.Entities;

public class Response
{
    public int Id { get; set; }
    public int QuestionnaireId { get; set; }
    public Questionnaire Questionnaire { get; set; }
    public List<SectionResponse> SectionResponses { get; set; } = new(); // New list for section responses
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
}