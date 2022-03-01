using System.Collections;
using System.IO;
using System.Linq;
namespace Project_Management_Application
{
    public class Program
    {
        private static List<Project> _projects = new();
        
        public static void Main(string[] args)
        {
            string textFile = "D:\\Aisha's Dir.Files\\Training\\Projects\\Project Management Application\\data.txt";
            _projects = FilesManager.ReadDataFromFile(textFile);
            
            while (true)
            {
                Console.Write($@"What do you need? 
            1- List of available projects?
            2- Search on
            3- Close
            Enter your choice: ");
                int _command = int.Parse(Console.ReadLine());
                switch (_command)
                {
                    case 1:
                        ProjectFactory.PrintAllProjects(_projects);
                        break;
                    case 2:
                        Filtration.Search(_projects);
                        break;
                    default:
                        Console.WriteLine("Close the program");
                        break;
                }
                if(_command==3)
                { break; }
            } 
        }        
    }
}