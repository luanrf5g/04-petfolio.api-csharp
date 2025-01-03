using Petfolio.Communications.Enums;

namespace Petfolio.Communications.Responses;

public class ResponseDetailsPetJson
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public DateTime Birthday { get; set; }

  public PetType Type { get; set; }
}
