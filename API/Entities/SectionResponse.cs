using API.Extensions;

namespace API.Entities;



public class SectionResponse
{
    public int Id { get; set; }
    public int SectionId { get; set; }
    public QuestionSection Section { get; set; }
    public List<Answer> Answers { get; set; } = new(); // List of answers in the section
}