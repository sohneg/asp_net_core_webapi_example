using webApi.Dtos;
using webApi.Models;

namespace webApi.Interfaces
{
  /// <summary>
  /// Schnittstelle für das TestModel-Repository.
  /// Definiert CRUD-Operationen für TestModelle, wie das Abrufen, Erstellen und Aktualisieren.
  /// </summary>
  public interface ITestModelRepository
  {
    /// <summary>
    /// Gibt eine Liste aller TestModelle zurück.
    /// </summary>
    /// <returns>Eine Liste von TestModel-Objekten.</returns>
    Task<List<TestModelDto>> GetAll();

    /// <summary>
    /// Gibt ein bestimmtes TestModel anhand der ID zurück.
    /// </summary>
    /// <param name="id">Die ID des gewünschten TestModels.</param>
    /// <returns>Das gefundene TestModel oder null, wenn es nicht existiert.</returns>
    Task<TestModel?> GetById(int id);

    /// <summary>
    /// Erstellt ein neues TestModel.
    /// </summary>
    /// <param name="testModel">Das zu erstellende TestModel.</param>
    /// <returns>Das neu erstellte TestModel.</returns>
    Task<TestModelDto> Create(CreateTestModelDto testModel);

    /// <summary>
    /// Aktualisiert ein bestehendes TestModel.
    /// </summary>
    /// <param name="testModel">Das aktualisierte TestModel.</param>
    /// <returns>Das aktualisierte TestModel oder null, wenn es nicht gefunden wurde.</returns>
    Task<TestModel?> Update(int testModelId, UpdateTestModelDto testModel);

    /// <summary>
    /// Löscht ein TestModel anhand der ID.
    /// </summary>
    /// <param name="id">Die ID des zu löschenden TestModels.</param>
    /// <returns>True, wenn das TestModel erfolgreich gelöscht wurde, andernfalls false.</returns>
    Task<bool> Delete(int id);
  }
}
