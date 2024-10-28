using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Microsoft.EntityFrameworkCore;
namespace API.Controllers;
public class QuestionnaireRepository(DataContext context, IMapper mapper) : IQuestionnaireRepository
{
   
    
    public async Task<IEnumerable<QuestionnaireDto>> GetQuestionnairesAsync()
    {
        return await context.Questionnaires
            .ProjectTo<QuestionnaireDto>(mapper.ConfigurationProvider)
            .ToListAsync();
    }
   
}