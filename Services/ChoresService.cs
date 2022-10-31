namespace chores.Services;

public class ChoresService
{
  private readonly FakeDb _db;
  public List<Chore> GetChores(){
    return _db.Chores;
  }
  public Chore GetChoreById(string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if(chore == null){
      throw new Exception("Invalid Id");
    }
    return chore;
  }

  public Chore AddChore( Chore choreData){
    _db.Chores.Add(choreData);
    return choreData; 
  }

  public ChoresService(FakeDb db){
    _db = db;
  }
}
