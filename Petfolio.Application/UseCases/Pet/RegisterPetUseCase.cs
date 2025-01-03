using Petfolio.Communications.Requests;
using Petfolio.Communications.Responses;

namespace Petfolio.Application.UseCases.Pet;

public class RegisterPetUseCase
{
  public ResponseRegisterPet Execute(RequestRegisterPet request)
  {
    return new ResponseRegisterPet
    {
      Id = 1,
      Name = request.Name,
    };
  }
}
