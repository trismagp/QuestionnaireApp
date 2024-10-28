
using API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using API.Interfaces;
using System.Security.Claims;

namespace API.Controllers;


public class QuestionnairesController(IQuestionnaireRepository questionnaireRepository, IMapper mapper) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<QuestionnaireDto>>> GetQuestionnaires()
    {
        var questionnaires = await questionnaireRepository.GetQuestionnairesAsync();
        return Ok(questionnaires);
    }

    
  
}
