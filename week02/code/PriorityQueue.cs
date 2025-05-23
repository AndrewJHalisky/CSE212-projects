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
    }

    public string Dequeue()
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
internal class PriorityItem (string value, int priority)
{
    internal string Value { get; set; } = value;
    internal int Priority { get; set; } = priority;

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}
 