public class ExampleClass{
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod() {
        int a = 5;
        int b = 0; 
        int c = a / b; // Potential DivideByZeroException
    }
}