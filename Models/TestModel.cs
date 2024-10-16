namespace webApi.Models
{
  /// <summary>
  /// Repräsentiert ein TestModel mit einer ID, einem Namen und einer Beschreibung.
  /// Dieses Modell wird für die Verwaltung von Testdaten verwendet.
  /// </summary>
  public class TestModel
  {
    /// <summary>
    /// Die eindeutige ID des TestModels.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Der Name des TestModels.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Eine Beschreibung des TestModels.
    /// </summary>
    public string Description { get; set; } = string.Empty;
  }
}
