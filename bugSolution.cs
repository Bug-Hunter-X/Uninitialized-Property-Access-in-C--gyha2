public class ExampleClass
{
    private int _myVariable = 0; // Initialize with a default value

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value; }
    }

    public void MyMethod()
    {
        // Now safe, even if MyProperty was never explicitly set
        int x = MyProperty * 2; 
    }

    public ExampleClass() { }
    public ExampleClass(int value) { _myVariable = value; }
}