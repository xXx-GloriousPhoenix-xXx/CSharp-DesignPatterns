namespace DesignPatterns.Composite.MenuSystem
{
    public interface IFileSystemComponent
    {
        public string GetName();
        public int GetSize();
        public void Display(int indent = 0);
        public IFileSystemComponent? ParentComponent { get; set; }
    }
    public class File(string name, int size, IFileSystemComponent? parentComponent = null) : IFileSystemComponent
    {
        private readonly string name = name;
        private readonly int size = size;
        public IFileSystemComponent? ParentComponent { get; set; } = parentComponent;
        public string GetName() => name;
        public int GetSize() => size;
        public void Display(int indent = 0)
        {
            var stringSize = SizeConverter.GetSizeString(size);
            var stringIndent = new string(' ', 3 * indent);
            Console.WriteLine($"{stringIndent}{name} ({stringSize})");
        }

    }
    public class Directory(string name, IFileSystemComponent? parentComponent = null) : IFileSystemComponent
    {
        private readonly string name = name;
        public IFileSystemComponent? ParentComponent { get; set; } = parentComponent;
        private readonly List<IFileSystemComponent> fileComponents = [];
        public string GetName() => name;
        public int GetSize()
        {
            return fileComponents.Select(fc => fc.GetSize()).Sum();
        }
        public void Add(IFileSystemComponent file)
        {
            file.ParentComponent = this;
            fileComponents.Add(file);
        }
        public void Remove(IFileSystemComponent file)
        {
            fileComponents.Remove(file);
        }
        public void Display(int indent = 0)
        {
            var stringIndent = new string(' ', 3 * indent);
            Console.WriteLine($"{stringIndent}{name}/");
            foreach (var fc in fileComponents)
            {
                fc.Display(indent + 1);
            }
            if (ParentComponent is null)
            {
                var size = GetSize();
                var sizeString = SizeConverter.GetSizeString(size);
                Console.WriteLine($"Total size of {name}: {sizeString}");
            }
        }
    }
    public static class SizeConverter
    {
        private static readonly List<string> sizeNames = ["B", "KB", "MB", "GB", "TB", "PB"];
        public static string GetSizeString(int byteSize)
        {
            var i = 0;
            while (byteSize > 1024)
            {
                byteSize /= 1024;
                i++;
            }
            return $"{byteSize} {sizeNames[i]}";
        }
    }
}
