class Program
{
    static void Main(string[] args)
    {
        FileSystem fileSystem = new FileSystem();

        // a) Creating a FileSystem.
        fileSystem.Add(new File("AnImage", "jpg", 5342));

        // b) Adding files to the file system.
        File file2 = new File("SomeFile", "txt", 832);
        fileSystem.Add(file2);

        // c) Adding a folder that contains files to the file system.
        Folder saveFiles = new Folder("Save files");
        saveFiles.Add(new File("Save 1 – The Citadel", "data", 2348));
        saveFiles.Add(new File("Save 2 – Artemis Tau", "data", 6378));
        saveFiles.Add(new File("Save 3 – Serpent Nebula", "data", 973));
        fileSystem.Add(saveFiles);

        // d) Adding a folder that contains a folder that contains files to the file system.
        // e) Adding an empty folder to the file system.
        Folder newFolder = new Folder("New folder");
        fileSystem.Add(newFolder);

        // f) Calling the PrintContents method.
        fileSystem.PrintContents();
    }
}
