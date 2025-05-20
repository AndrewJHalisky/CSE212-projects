using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var first = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", first.Name);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", second.Name);

        var third = priorityQueue.Dequeue();
        Assert.AreEqual("Sue", third.Name);
        
        Assert.IsTrue(priorityQueue.IsEmpty());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        
        var first = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", first.Name);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", second.Name);

        var third = priorityQueue.Dequeue();
        Assert.AreEqual("Sue", third.Name);

        Assert.IsTrue(priorityQueue.IsEmpty());
    }

    // Add more test cases as needed below.
}