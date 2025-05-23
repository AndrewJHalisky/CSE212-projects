
using Microsoft.VisualBasic;

public class Person(string name, int turns)
{
    public string Name { get; } = name;
    public int Turns { get; } = turns;

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}