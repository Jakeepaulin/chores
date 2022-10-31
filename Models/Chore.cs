using chores.Enums;

namespace chores.Models;

public class Chore
{
public string Id { get; private set; }
public string Name { get; private set; }
public bool IsDone { get; private set; }
public TypeOfChore Location { get; private set; }

public void ChangeName(string name ){
    Name = name;
  }

public Chore ( string name, bool isDone, TypeOfChore location){

    Id = Guid.NewGuid().ToString();
    Name = name;
    IsDone = isDone;
    Location = location;
  } 

}