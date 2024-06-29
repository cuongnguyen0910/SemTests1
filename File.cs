public class File : Thing
{
    private string _extension;
    private int _size;

    public File(string name, string extension, int size) : base(name)
    {
        _extension = extension;
        _size = size;
    }

    public override int Size()
    {
        return _size;
    }

    public override void Print(string indent = "")
    {
        Console.WriteLine($"{indent}File '{_name}.{_extension}' -- {_size} bytes");
    }
}
