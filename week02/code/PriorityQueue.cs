using System.Data;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new List<PriorityItem>();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    /// 
    public void Enqueue(string person, int priority)
    {
        var newNode = new PriorityItem(person, priority);
        _queue.Add(newNode);
        _queue = _queue.OrderBy(p => p.Priority).ToList();
    }

    public Person Dequeue()
    {
        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count - 1; index++)
        {
            if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var person = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return person;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }


}

internal class PriorityItem
{
    private string person;

    internal Person Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(Person value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public PriorityItem(string person, int priority)
    {
        this.person = person;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}
 