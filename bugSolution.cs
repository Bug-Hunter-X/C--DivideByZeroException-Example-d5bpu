public class ExampleClass{
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod() {
        int a = 5;
        int b = 0; 
        try {
            int c = a / b; 
        } catch (DivideByZeroException ex) {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Handle the exception appropriately, e.g., log the error, return a default value, etc.
        }
    }
}