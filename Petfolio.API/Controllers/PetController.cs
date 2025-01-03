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
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPet request)
    {
      var response = new RegisterPetUseCase().Execute(request);

      return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPet request)
    {
      var useCase = new UpdatePetUseCase();
      useCase.Execute(id, request);

      return NoContent();
    }
  }
}
