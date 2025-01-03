using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet;
using Petfolio.Communications.Requests;
using Petfolio.Communications.Responses;

namespace Petfolio.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PetController : ControllerBase
  {
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPet), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPet request)
    {
      var response = new RegisterPetUseCase().Execute(request);

      return Created(string.Empty, response);
    }
  }
}
