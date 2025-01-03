using System;
using Petfolio.Communications.Responses;

namespace Petfolio.Application.UseCases.Pet;

public class FetchPetsUseCase
{
  public ResponseFetchPetsJson Execute()
  {
    return new ResponseFetchPetsJson
    {
      Pets = [
        new() {
          Id = 1,
          Name = "Rex",
          Type = Communications.Enums.PetType.Dog,
        },
        new() {
          Id = 1,
          Name = "Levi",
          Type = Communications.Enums.PetType.Cat,
        },
      ],
    };
  }
}
