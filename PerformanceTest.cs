namespace Box;
using System.Diagnostics;
//  This code tests the performance of the Box class.
// You may use this as a starting place for your code by replacing the 
// methods in this class with your own methods that test the performance of
// the Enqueue, Dequeue, Peek, and Contains methods in your Queue<T> class.
// Be sure to comment your code.
public class PerformanceTest
{
    public static void RunPerformanceTests()
    {
        // Test 1: See how long it takes to do a setItem
        Console.WriteLine("\nPerformance Test 1 - SetItem");
        Stopwatch stopwatch = new Stopwatch();
        Box<int> testBox = new Box<int>(3);
        stopwatch.Start();
        testBox.SetItem(0);
        stopwatch.Stop();
        Console.WriteLine($"Time taken: {stopwatch.ElapsedTicks}");
        
        // see how long it takes to do a GetItem
        Console.WriteLine("\nPerformance Test 2 - GetItem");
        stopwatch.Restart(); // clears time and start timer again
        testBox.GetItem();
        stopwatch.Stop();
        Console.WriteLine($"Time taken: {stopwatch.ElapsedTicks}");    
        
    }
}