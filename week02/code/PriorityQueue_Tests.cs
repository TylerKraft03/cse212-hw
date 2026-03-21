using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items and dequeue the one with the highest priority.
    // Expected Result: "high" is dequeued first.
    // Defect(s) Found: Dequeue did not remove element or preserve highest.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("med", 5);
        priorityQueue.Enqueue("high", 9);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Enqueue items with tied high priority and verify FIFO among ties.
    // Expected Result: "B" is dequeued first, then "C".
    // Defect(s) Found: When using >=, old value replaced new and FIFO was broken.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 7);
        priorityQueue.Enqueue("C", 7);
        priorityQueue.Enqueue("D", 2);

        var first = priorityQueue.Dequeue();
        Assert.AreEqual("B", first);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("C", second);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty.".
    // Defect(s) Found: None once implemented correctly.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty.");
    }

    // Add more test cases as needed below.
}