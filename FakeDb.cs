using chores.Enums;

namespace chores.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Washing the Dishes", false, TypeOfChore.Kitchen),
    new Chore("Make my Bed", true, TypeOfChore.Bedroom),
    new Chore("Pick up Dog Turds", false, TypeOfChore.Outside),
    new Chore("Make Dinner", true, TypeOfChore.Kitchen),
  };
}