public class FileSystem
{
    private List<Thing> _contents;

    public FileSystem()
    {
        _contents = new List<Thing>();
    }

    public void Add(Thing toAdd)
    {
        _contents.Add(toAdd);
    }

    public void PrintContents()
    {
        Console.WriteLine("This file system contains:");
        foreach (var item in _contents)
        {
            item.Print("  ");
        }
    }
}
