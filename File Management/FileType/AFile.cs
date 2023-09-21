namespace File_Management.FileType
{
    public abstract class AFile
    {
        public string Name { get; private set; }
        protected readonly string path = GetPath.Path();
        public AFile(string name)
        {
            Name = name;
        }

        public abstract void Display();


        public bool Add()
        {

            File.Create(path + Name);

            return true;

        }


        public bool Remove()
        {
            File.Delete(path + Name);
            return true;


        }

        public bool Write(string content)
        {

            Console.WriteLine($"Your Content '{content}' Added to File {path + Name} ");
            return true;

        }

    }
}
