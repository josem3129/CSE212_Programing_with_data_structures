using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: Item1 (1), Item2 (2), Item3 (3) and find the item with the highest priority
    // Expected Result: Item3
    // Defect(s) Found: For loop was not iterating through the entire queue. Changed the for loop to iterate through the entire queue.
    public void TestPriorityQueue_1()
    {

        var item1 = new PriorityItem("Item1", 1);
        var item2 = new PriorityItem("Item2", 5);
        var item3 = new PriorityItem("Item3", 3);

        var expectedItem = "Item2";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        
        var priorityItem = priorityQueue.Dequeue();

        Assert.AreEqual(expectedItem, priorityItem);
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: Item1 (1), Item2 (3), Item3 (3) and find the item with the highest priority from repeated priorities
    // Expected Result: Item2
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var item1 = new PriorityItem("Item1", 1);
        var item2 = new PriorityItem("Item2", 3);
        var item3 = new PriorityItem("Item3", 3);

        var expectedItem = "Item2";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        
        var priorityItem = priorityQueue.Dequeue();

        Assert.AreEqual(expectedItem, priorityItem);
    }

    // Add more test cases as needed below.
}