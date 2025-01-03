using Petfolio.Communications.Responses;

namespace Petfolio.Application.UseCases.Pet;

public class DetailsPetUseCase
{
  public ResponseDetailsPetJson Execute(int id)
  {
    return new ResponseDetailsPetJson
    {
      Id = 7,
      Name = "Rex",
      Birthday = new DateTime(year: 2019, month: 1, day: 1),
      Type = Communications.Enums.PetType.Dog,
    };
  }
}
