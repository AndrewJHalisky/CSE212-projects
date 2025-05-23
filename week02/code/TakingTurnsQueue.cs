using System.Collections;
using System.Diagnostics;
using System.Security;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
/// <summary>
/// This queue is circular.  When people are added via AddPerson, then they are added to the 
/// back of the queue (per FIFO rules).  When GetNextPerson is called, the next person
/// in the queue is saved to be returned and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>
public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();
    private Queue<Person> _queue = new Queue<Person>();

    public int Length => _people.Length;

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns remaining</param>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _queue.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue and return them. The person should
    /// go to the back of the queue again unless the turns variable shows that they 
    /// have no more turns left.  Note that a turns value of 0 or less means the 
    /// person has an infinite number of turns.  An error exception is thrown 
    /// if the queue is empty.
    /// </summary>

    public override string ToString()
    {
        return _people.ToString();
    }

    public Person GetNextPerson()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("No one in the queue.");

        var person = _queue.Dequeue();

        if (person.Turns <= 0)
        {
            _queue.Enqueue(person);
        }
        else
        {
            int remainingTurns = person.Turns - 1;
            if (remainingTurns > 0)
            {
                _queue.Enqueue(new Person(person.Name, remainingTurns));
            }
        }
        return person;
    }

    internal Person Peek()
    {
        if (_queue.Count > 0)
            return _queue.Peek();
        else
            return null;
    }

}