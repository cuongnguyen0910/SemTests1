public abstract class Thing
{
    protected string _name;

    public Thing(string name)
    {
        _name = name;
    }

    public string Name => _name;

    public abstract int Size();

    public abstract void Print(string indent = "");
}
