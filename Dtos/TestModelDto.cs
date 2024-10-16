namespace webApi.Dtos
{
  /// <summary>
  /// DTOs (Data Transfer Objects) sind einfache Klassen, die zum Übertragen von Daten 
  /// verwendet werden. Man kann hier entscheiden welche Felder verfügbar sind und welche nicht.
  /// Sie enthalten keine Geschäftslogik und transportieren nur die benötigten Informationen.
  /// </summary>

  public class TestModelDto
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
  }

  public class CreateTestModelDto
  {
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
  }

  public class UpdateTestModelDto
  {
    public string Description { get; set; } = string.Empty;
  }
}