using API.DTOs;
using API.Entities;
namespace API.Interfaces;
public interface IQuestionnaireRepository
{
    Task<IEnumerable<QuestionnaireDto>> GetQuestionnairesAsync();
    
    
}