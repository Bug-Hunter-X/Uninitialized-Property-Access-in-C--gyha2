public class ExampleClass
{
    private int _myVariable;

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value; }
    }

    public void MyMethod()
    {
        // This line might cause an exception if MyProperty is never set
        int x = MyProperty * 2; 
    }
}