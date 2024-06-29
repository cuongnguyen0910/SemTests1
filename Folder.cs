public class Folder : Thing
{
    private List<Thing> _contents;

    public Folder(string name) : base(name)
    {
        _contents = new List<Thing>();
    }

    public void Add(Thing toAdd)
    {
        _contents.Add(toAdd);
    }

    public override int Size()
    {
        int totalSize = 0;
        foreach (var item in _contents)
        {
            totalSize += item.Size();
        }
        return totalSize;
    }

    public override void Print(string indent = "")
    {
        if (_contents.Count > 0)
        {
            Console.WriteLine($"{indent}The folder '{_name}' contains {Size()} bytes total:");
            foreach (var item in _contents)
            {
                item.Print(indent + "  ");
            }
        }
        else
        {
            Console.WriteLine($"{indent}The folder '{_name}' is empty!");
        }
    }
}
