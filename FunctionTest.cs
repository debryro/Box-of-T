using System.Diagnostics;

namespace Box;

// This class contains function tests for the Box class
// You may use this as a starting point for your own code by 
// replacing the methods in this class with your own methods
// that test the functionality of the code in your Queue<T> class.
// Please write methods as shown below instead of trying to write
// unit tests as you have seen in prior assignments in this class.
// Be sure to comment your code.
public class FunctionTest
{
    public static void RunFunctionTests()
    {
        // Test 1: Create a Box object with a value of 3 
        // then get the value stored in the box.
        // Test to see if the value is 3
        Box<int> testBox = new Box<int>(3);
        if (testBox.GetItem() == 3)
        {
            Console.WriteLine("\nFunction Test 1 passed");
        }
        else
        {
            Console.WriteLine("\nFunction Test 1 failed");
        }
        
        // Test 2: Change the value in the Box object to 5
        // change the value to 5
        // Test to see if the value is now 5
        testBox.SetItem(5);
        if (testBox.GetItem() == 5)
        {
            Console.WriteLine("\nFunction Test 2 passed");
        }
        else
        {
            Console.WriteLine("\nFunction Test 2 failed");
        }    
    } 
}