using Petfolio.Communications.Enums;

namespace Petfolio.Communications.Requests;

public class RequestRegisterPet
{
  public string Name { get; set; } = string.Empty;

  public DateTime Birthday { get; set; }

  public PetType Type { get; set; }
}
