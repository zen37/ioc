public class MyClass
{

    private readonly IMyInterface _myDependency;

    public MyClass(IMyInterface myDependency)
    {
        _myDependency = myDependency;

    }

    public void ThisIsAMethod()
    {
        _myDependency.ThisIsAMethod();
    }
}