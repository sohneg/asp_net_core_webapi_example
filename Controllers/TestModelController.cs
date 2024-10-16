using Microsoft.AspNetCore.Mvc;
using webApi.Models;
using webApi.Interfaces;
using webApi.Dtos;

namespace webApi.Controllers
{
  /// <summary>
  /// Controller zur Verwaltung von TestModellen.
  /// Er bietet Endpunkte für CRUD-Operationen (Erstellen, Lesen, Aktualisieren, Löschen).
  /// </summary>
  [ApiController]
  [Route("[controller]")]
  public class TestModelController : ControllerBase
  {
    private readonly ITestModelRepository _testModelRepo;

    /// <summary>
    /// Initialisiert eine neue Instanz des TestModelController mit dem angegebenen Repository.
    /// </summary>
    /// <param name="testModelRepo">Das Repository für TestModel-Operationen.</param>
    public TestModelController(ITestModelRepository testModelRepo)
    {
      _testModelRepo = testModelRepo;
    }

    /// <summary>
    /// Gibt eine Liste aller TestModelle zurück.
    /// </summary>
    /// <returns>Eine Liste von TestModel-Objekten.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TestModel>>> GetAll()
    {
      var result = await _testModelRepo.GetAll();
      return Ok(result);
    }

    /// <summary>
    /// Gibt ein bestimmtes TestModel anhand der ID zurück.
    /// </summary>
    /// <param name="id">Die ID des gewünschten TestModels.</param>
    /// <returns>Das gefundene TestModel oder 404 Not Found, wenn es nicht existiert.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<TestModel>> GetById(int id)
    {
      var result = await _testModelRepo.GetById(id);

      if (result == null)
      {
        return NotFound("Test Model nicht gefunden");
      }

      return Ok(result);
    }

    /// <summary>
    /// Erstellt ein neues TestModel.
    /// </summary>
    /// <param name="testModel">Das zu erstellende TestModel.</param>
    /// <returns>Das neu erstellte TestModel mit dem HTTP-Statuscode 201 Created.</returns>
    [HttpPost]
    public async Task<ActionResult<TestModel>> Create(CreateTestModelDto testModel)
    {
      var result = await _testModelRepo.Create(testModel);
      return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    /// <summary>
    /// Aktualisiert ein bestehendes TestModel anhand der ID.
    /// </summary>
    /// <param name="id">Die ID des zu aktualisierenden TestModels.</param>
    /// <param name="testModel">Das aktualisierte TestModel-Objekt.</param>
    /// <returns>Das aktualisierte TestModel oder 404 Not Found, wenn das Modell nicht existiert.</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult<TestModel>> Update(int id, UpdateTestModelDto testModel)
    {
      var existingModel = await _testModelRepo.GetById(id);
      if (existingModel == null)
      {
        return NotFound("Test Model nicht gefunden");
      }

      var updatedModel = await _testModelRepo.Update(id, testModel);

      return Ok(updatedModel);
    }

    /// <summary>
    /// Löscht ein TestModel anhand der ID.
    /// </summary>
    /// <param name="id">Die ID des zu löschenden TestModels.</param>
    /// <returns>Ein HTTP-Statuscode 200 OK, wenn das Löschen erfolgreich war, oder 404 Not Found, wenn das TestModel nicht existiert.</returns>
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var success = await _testModelRepo.Delete(id);
      if (!success)
      {
        return NotFound("TestModel nicht gefunden.");
      }

      return Ok($"TestModel mit ID {id} wurde erfolgreich gelöscht.");
    }
  }
}
