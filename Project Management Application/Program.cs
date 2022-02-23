using System.IO;

namespace Project_Management_Application
{
    public class Program
    {
        private static List<Project> _projects = new();
        private static string? _choice;
        public static void Main(string[] args)
        {
            List<Task> Pro1Tasks = new();
            Pro1Tasks.Add(new Task("task1", "descroiption for task1", "Ahmad"));
            Project p1 = new("project1", new string[2] { "Ahmad", "Salwa" },Pro1Tasks);
            p1.AddUser("Noor");
            _projects.Add(p1);

            List<Task> Pro2Tasks = new();
            Pro2Tasks.Add(new Task("task2", "description for task2", "Samer"));
            Pro2Tasks.Add(new Task("task3", "description for task3", "Mohammad"));
            Project p2 = new("project2", new string[2] { "Samer", "Mohammad" }, Pro2Tasks.ToList());
            _projects.Add(p2);

            Project p3 = new("project3");
            _projects.Add(p3);
            //Console.WriteLine(p3.Tasks.ToList().Count);

            string listOfCommands = $@"What do you need? 
            1- List of available projects?
            2- Search on
            3- Close
            Enter your choice: ";
            Console.Write(listOfCommands);
            int _command = int.Parse(Console.ReadLine());
            switch (_command)
            {
                case 1:
                    foreach (var project in _projects)
                    {
                        project.PrintProjectInfo();
                        Console.WriteLine("============");
                    }
                    break;
                case 2:
                    Search();
                    break;
                default:
                    Console.WriteLine("Close the program");
                    break;
            }
        }
        private static void Search()
        {
            bool _confirmed = false;
            int _counter = 0;
            string [] _listOfChoices = {"Project Name","Task Name","Task Status","Assigned User"};
            do
            {
                Console.WriteLine($"Search on {_listOfChoices[_counter]}: ");
                _choice = Console.ReadLine();
                if (!string.IsNullOrEmpty(_choice))
                {
                    _confirmed = true;
                    break;
                }
                else if(string.IsNullOrEmpty(_choice))
                {
                    _counter++;
                }
            }
            while (!_confirmed && (_counter < _listOfChoices.Length));

            foreach (var project in _projects)
            {
                switch(_counter)
                {
                    case 0:
                        if (project.ProjectName.Contains(_choice))
                        {
                            project.PrintProjectInfo();
                        }
                        break;
                    case 1:
                    case 2: 
                    case 3:
                        if(project.Tasks.Count!=0)
                        {
                            foreach (var task in project.Tasks)
                            {
                                if ((_counter == 1) && (task.Title.Contains(_choice)))
                                {
                                    Console.WriteLine(task);
                                }
                                else if ((_counter == 2) && (task.Status.Equals(_choice)))
                                {
                                    Console.WriteLine(task);
                                }
                                else if ((_counter == 3) && (task.User.Equals(_choice)))
                                {
                                    Console.WriteLine(task);
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}