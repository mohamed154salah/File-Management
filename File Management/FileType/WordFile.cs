namespace File_Management.FileType
{
    public class WordFile : AFile
    {
        public WordFile(string name) : base(name)
        {
        }

        public override void Display()
        {

            Console.WriteLine($"Word File Displayed with path {path + Name}");

        }


    }
}
