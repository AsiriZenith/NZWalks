using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> userManager;

    public AuthController(UserManager<IdentityUser> userManager)
    {
        this.userManager = userManager;
    }

    // POST: api/auth/Register
    [HttpPost]
    [Route("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto) 
    {
        var identityUser = new IdentityUser
        {
            UserName = registerRequestDto.Username,
            Email = registerRequestDto.Username,
        };

        var identityResult = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

        if (!identityResult.Succeeded)
        {
            return BadRequest(identityResult.Errors);
        }
        else
        {
            if (registerRequestDto.Roles is null || registerRequestDto.Roles.Length == 0)
            {
                return BadRequest(new { Message = "At least one role must be specified" });
            }

            var identityRole = await userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

            if (!identityRole.Succeeded) {
                return BadRequest(identityResult.Errors);
            }

            return Ok(new { Message = "User registered successfully" });
        }
    }
}
