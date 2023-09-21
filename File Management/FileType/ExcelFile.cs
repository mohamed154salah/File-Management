namespace File_Management.FileType
{
    public class ExcelFile : AFile
    {
        public ExcelFile(string name) : base(name)
        {
        }


        public override void Display()
        {

            Console.WriteLine($"Excel File Displayed with path {path + Name}");

        }
    }
}
