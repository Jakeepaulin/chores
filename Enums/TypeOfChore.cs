using System.Text.Json.Serialization;

namespace chores.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TypeOfChore{
  Outside,
  Bathroom,
  Kitchen,
  Bedroom
}