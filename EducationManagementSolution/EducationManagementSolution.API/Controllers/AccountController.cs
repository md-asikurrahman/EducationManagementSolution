using MediatR;
using Microsoft.AspNetCore.Mvc;
using EducationManagementSolution.API.Models.AccountModel;

namespace EducationManagementSolution.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AccountController : BaseController
{
	private readonly ISender _sender;
    public AccountController(ISender sender)
    {
	    _sender = sender;
    }

    [HttpPost]
	public async Task<IActionResult> LogIn([FromQuery] LogInModel model)
	{
		try
		{

			return Ok();
		}
		catch (Exception ex)
		{

			throw ;
		}
		
	}
}
