using System.Collections;
using System.IO;
using System.Linq;
namespace Project_Management_Application
{
    public class Program
    {
        private static List<Project> _projects = new();
        
        public static void Main()
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
                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        foreach (var project in _projects)
                        {
                            Console.WriteLine(project);
                        }
                        break;
                    case 2:
                        string[] SearchUserInput = ProjectsUserInputReader.GetSearchInput();
                        List <Task> result = TasksFiltration.Search(_projects, SearchUserInput);
                        foreach (var task in result)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    default:
                        Console.WriteLine("Close the program");
                        break;
                }
                if(command==3)
                { break; }
            } 
        }        
    }
}