using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test the queue to make sure it enqueues the names in the correct order, then dequeues it to make sure they work.
    // Expected Result: Nothing to show, but it shows that they enqueued and dequeued correcty.
    // Defect(s) Found: When the test fails, it shows that the queue was not handled in the code, meaning that is was empty.
    public void TestPriorityQueue_DequeueCorrectOrder()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Bob", 2);

        var third = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", third);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("Sue", second);

        var first = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", first);

        Assert.IsTrue(priorityQueue.IsEmpty());
    }

    [TestMethod]
    // Scenario: Makes sure that the name at the front of the queue was removed, then that name will be displayed
    // Expected Result: Before removal: Bob Sue Tim  Removed item: Bob  After removal: Sue Tim 
    // Defect(s) Found: When it fails, it shows that the queue was not modified in the code and that the code failed to remove the item.
    public void TestPriorityQueue_RemoveItemClosetToFront()
    {
        var priorityQueue = new PriorityQueue<string, int>();

        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Bob", 2);

        Console.WriteLine("\nBefore removal: ");
        PrintQueue(priorityQueue);

        string removedItem = priorityQueue.Dequeue();
        Console.WriteLine($"\nRemoved item: {removedItem}");

        Console.WriteLine("\nAfter removal:");
        PrintQueue(priorityQueue);
    }

    [TestMethod]
    // Scenario: Removes the person in the list that has the highest priority number. Then displays that person with their number.
    // Expected Result: Removed Tim from the list. Max number was 5
    // Defect(s) Found: When the test fails, it states that the top priority number was not recognized in the List due to a int variable being called something different.
    public void TestPriorityQueue_RemoveHighestPriority()
    {
        var people = new List<(string Name, int Priority)>
        {
            ("Tim", 5),
            ("Sue", 3),
            ("Bob", 2)
        };

        var maxPriorityItem = people.OrderByDescending(x => x.Priority).First();
        people.Remove(maxPriorityItem);

        Console.WriteLine($"Removed {maxPriorityItem.Name} from the list. Max number was {maxPriorityItem.Priority}");
    }

    [TestMethod]
    // Scenario: Makes sure that if there is an error in the queue, it displays a message saying that it cannot be empty.
    // Expected Result: Error: Cannot dequeue due to empty queue.
    // Defect(s) Found: When the test fails, it does not recognize the error due to the person still being listed in the queue.
    public void TestPriorityQueue_CatchErrorIfEmpty()
    {
        var priorityQueue = new PriorityQueue<string, int>();
        try
        {
            string person = priorityQueue.Dequeue();
            Console.WriteLine($"Removed Person: {person}");
        }
        catch {
            Console.WriteLine("Error: Cannot dequeue due to empty queue.");
        }
    }

    private static void PrintQueue(PriorityQueue<string, int> queue)
    {
        var tempQueue = new PriorityQueue<string, int>(queue.UnorderedItems);

        while (tempQueue.Count > 0)
        {
            var item = tempQueue.Dequeue();
            Console.WriteLine(item);
        }
    }
}