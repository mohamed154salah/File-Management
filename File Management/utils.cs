using File_Management.FileType;

namespace File_Management
{
    public class Utils
    {
        public Utils()
        {
            AFile file = null!;
            bool con = true;
            while (con)
            {
                file = CreateFile();
                if (file != null)
                {
                    chooseOperation(file);
                }
                else
                {
                    Console.WriteLine("You Choose File Type Not Exists");
                }
                Console.WriteLine("Enter 5- if Want to exit");
                string? y = Console.ReadLine();
                _ = y == "5" ? con = false : con = true;
            }
        }

        public AFile CreateFile()
        {
            AFile? file = null;
            Console.WriteLine("Enter File Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter File Type 1 for PDF ,2 for Word ,3 for Excel");
            string type = Console.ReadLine();

            file = type switch
            {
                "1" => new PDFFile(name + ".pdf"),
                "2" => new WordFile(name + ".docx"),
                "3" => new ExcelFile(name + ".xlsx"),
                _ => null
            };
            return file;
        }


        public void chooseOperation(AFile file)
        {



            bool exists = File.Exists(GetPath.Path() + file.Name);
            if (exists)
            {
                Console.WriteLine("File Exists choose what you want");
                Console.WriteLine("1- for display file\n" +
                                 "2- to Remove File\n" +
                                 "3- To Write Content\n");
                string x = Console.ReadLine();

                switch (x)
                {
                    case "1":
                        file.Display();
                        break;
                    case "2":
                        file.Remove();
                        break;
                    case "3":
                        Console.WriteLine("Enter your content to add to the file:");
                        string content = Console.ReadLine();
                        file.Write(content);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("File Not Exists Want To Create press 'enter'");
                Console.ReadKey();
                file.Add();


            }

        }

    }
}
