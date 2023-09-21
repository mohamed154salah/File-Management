namespace File_Management.FileType
{
    public class PDFFile : AFile
    {
        public PDFFile(string name) : base(name)
        {

        }

        public override void Display()
        {

            Console.WriteLine($"PDF File Displayed with path {path + Name}");

        }




    }
}
