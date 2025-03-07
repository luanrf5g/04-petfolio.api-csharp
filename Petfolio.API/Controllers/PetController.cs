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

    [HttpGet]
    [ProducesResponseType(typeof(ResponseFetchPetsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult FetchPets()
    {
      var useCase = new FetchPetsUseCase();
      var response = useCase.Execute();

      if (response.Pets.Count == 0)
      {
        return NoContent();
      }

      return Ok(response);

    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseDetailsPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
      var useCase = new DetailsPetUseCase();
      var response = useCase.Execute(id);

      return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
      var useCase = new DeletePetUseCase();
      useCase.Execute(id);

      return NoContent();
    }
  }
}
