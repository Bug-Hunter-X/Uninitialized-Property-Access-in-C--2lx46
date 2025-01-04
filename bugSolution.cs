public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        this.MyProperty = 0; // Or another default value 
    }

    public void MyMethod()
    {
        // Accessing the property after initialization
        int value = this.MyProperty; 
    }
}