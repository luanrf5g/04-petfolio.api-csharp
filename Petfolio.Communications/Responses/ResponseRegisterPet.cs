using System;

namespace Petfolio.Communications.Responses;

public class ResponseRegisterPet
{
  public int Id { set; get; }

  public string Name { get; set; } = string.Empty;
}
