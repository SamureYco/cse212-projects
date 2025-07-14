using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
// Scenario: Add three elements with different priorities: "Low" (1), "Medium" (5), and "High" (10).
// Expected Result: The Dequeue method should return "High" first, then "Medium", then "Low".
// Defect(s) Found: Originally, the loop in Dequeue did not evaluate the last item in the queue,
// so "High" (the last item) was never returned. Also, items were not being removed after Dequeue,
// so the same item was returned multiple times. Both issues were fixed.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
// Scenario: Add three elements with the same priority: "First", "Second", and "Third" (all priority 5).
// Expected Result: The Dequeue method should return "First", then "Second", then "Third",
// maintaining FIFO order for elements with the same priority.
// Defect(s) Found: Originally, elements with the same priority did not always respect insertion order (FIFO).
// This was fixed by adjusting the comparison to use '>' instead of '>=' when selecting highest priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}