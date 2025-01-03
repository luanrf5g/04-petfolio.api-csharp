using Petfolio.Communications.Enums;

namespace Petfolio.Communications.Responses;

public class ResponseShortPetJson
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public PetType Type { get; set; }
}
