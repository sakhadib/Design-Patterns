using CompositePattern.Composite;
using CompositePattern.Leaf;
using CompositePattern.Interface;

class main
{
    public static void Main(string[] args)
    {
        // Create Files
        IFileSystemComponent file1 = new ShuvroFile("Document1.txt");
        IFileSystemComponent file2 = new ShuvroFile("Image1.jpg");
        IFileSystemComponent file3 = new ShuvroFile("Document2.txt");
        IFileSystemComponent file4 = new ShuvroFile("Image2.jpg");
        IFileSystemComponent file5 = new ShuvroFile("Document3.txt");

        // Create Folders
        IFileSystemComponent folder1 = new Folder("Folder1");
        IFileSystemComponent folder2 = new Folder("Folder2");
        IFileSystemComponent folder3 = new Folder("Folder3");

        // Add files to Folder1
        ((Folder)folder1).Add(file1);
        ((Folder)folder1).Add(file2);

        // Add files to Folder2
        ((Folder)folder2).Add(file3);
        ((Folder)folder2).Add(folder3);
        
        // Add files to Folder3
        ((Folder)folder3).Add(file4);
        ((Folder)folder3).Add(file5);

        // Create a root folder and add folders to it
        IFileSystemComponent rootFolder = new Folder("RootFolder");
        ((Folder)rootFolder).Add(folder1);
        ((Folder)rootFolder).Add(folder2);

        // Display the entire folder structure
        Console.WriteLine("File System Structure:");
        rootFolder.Display(0);
    }
    
}