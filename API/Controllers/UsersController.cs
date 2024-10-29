
using API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using API.Interfaces;
using System.Security.Claims;
using API.Extensions;
using API.Entities;

namespace API.Controllers;

[Authorize]
public class UsersController(IUserRepository userRepository, IMapper mapper) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        var users = await userRepository.GetMembersAsync();
        return Ok(users);
    }

    
    [HttpGet("{username}")]  // /api/users/2
    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        var user = await userRepository.GetMemberAsync(username);
        if (user == null) return NotFound(); 
        return user;
    }

    [HttpPut]
    public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
    {
        var user = await userRepository.GetUserByUsernameAsync(User.GetUsername());

        mapper.Map(memberUpdateDto, user);

        if (await userRepository.SaveAllAsync()) return NoContent();
        return BadRequest("Failed to update the user");
    }


    [HttpPost("add-questionnaire")]
    public async Task<ActionResult<QuestionnaireDto>> AddQuestionnaire(QuestionnaireDto questionnaireDto)
    {
        var user = await userRepository.GetUserByUsernameAsync(User.GetUsername());

        if (user == null) return BadRequest("Cannot update user");

        var questionnaire = new Questionnaire
        {
            Title = questionnaireDto.Title,
            Description = questionnaireDto.Description
        };

        user.Questionnaires.Add(questionnaire);

        if (await userRepository.SaveAllAsync()) 
            return CreatedAtAction(nameof(GetUser), 
            new {username = user.UserName}, mapper.Map<QuestionnaireDto>(questionnaire));

        return BadRequest("Problem adding questionnaire");
    }

}
