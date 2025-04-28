namespace Box;
// You may use this code as a starting point for your project by
// replacing the Box class with the code for your Queue<T> class.

// This code defines the Box<T> class. 
public class Box<T>
{
    public T _item;

    /// <summary>
    /// Constructor
    /// Purpose: Initialize _value 
    /// </summary>
    /// <param name="value"></param>
    public Box(T value)
    {
        _item = value;
    }

    /// <summary>
    /// SetValue method
    /// Purpose: store a value in _item
    /// </summary>
    /// <param name="value"></param>
    public void SetItem(T value)
    {
        _item = value;
    }

    /// <summary>
    /// GetItem method
    /// Purpose: get the value of _item
    /// </summary>
    /// <returns></returns>
    public T GetItem()
    {
        return _item;
    }
}