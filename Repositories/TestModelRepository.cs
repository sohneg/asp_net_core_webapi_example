using webApi.Interfaces;
using webApi.Models;
using webApi.Dtos;

namespace webApi.Repositories
{
  /// <summary>
  /// Repository zur Verwaltung von TestModellen.
  /// Bietet Methoden für CRUD-Operationen (Erstellen, Lesen, Aktualisieren, Löschen).
  /// </summary>
  public class TestModelRepository : ITestModelRepository
  {
    private static List<TestModel> _testModels = new List<TestModel>
        {
            new TestModel { Id = 1, Name = "Test 1", Description = "Description 1" },
            new TestModel { Id = 2, Name = "Test 2", Description = "Description 2" }
        };

    public Task<List<TestModelDto>> GetAll()
    {
      var result = _testModels.Select(tm => new TestModelDto
      {
        Id = tm.Id,
        Name = tm.Name,
        Description = tm.Description
      }).ToList();

      return Task.FromResult(result);
    }


    public Task<TestModel?> GetById(int id)
    {
      var testModel = _testModels.FirstOrDefault(tm => tm.Id == id);
      return Task.FromResult(testModel);
    }

    public Task<TestModelDto> Create(CreateTestModelDto testModel)
    {
      var newTestModel = new TestModel
      {
        Id = _testModels.Count + 1,
        Name = testModel.Name,
        Description = testModel.Description
      };
      _testModels.Add(newTestModel);

      var result = new TestModelDto
      {
        Id = newTestModel.Id,
        Name = newTestModel.Name,
        Description = newTestModel.Description
      };

      return Task.FromResult(result);
    }

    public Task<TestModel?> Update(int testModelId, UpdateTestModelDto testModel)
    {
      var existingModel = _testModels.FirstOrDefault(tm => tm.Id == testModelId);
      if (existingModel != null)
      {
        existingModel.Description = testModel.Description;
      }
      return Task.FromResult(existingModel);
    }

    public Task<bool> Delete(int id)
    {
      var testModel = _testModels.FirstOrDefault(tm => tm.Id == id);
      if (testModel != null)
      {
        _testModels.Remove(testModel);
        return Task.FromResult(true);
      }
      return Task.FromResult(false);
    }
  }
}
