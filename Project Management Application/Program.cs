using System.IO;

namespace Project_Management_Application
{
    public class Program
    {
        private static List<Project> _projects = new();
        private static string? _choice;
        private static List<Task> _projectTasks = new();
        private static List<string> _projectUsers = new();
        public static void Main(string[] args)
        {
            _projectTasks.Add(new Task("task1", "descroiption for task1", "Ahmad"));
            _projectUsers.Add("Ahmad");
            _projectUsers.Add("Salwa");
            _projectUsers.Add("Noor");
            Console.WriteLine(_projectTasks.Count);
            ProjectFactory("project1", _projectUsers, _projectTasks);

            _projectTasks.Add(new Task("task2", "description for task2", "Samer"));
            _projectTasks.Add(new Task("task3", "description for task3", "Mohammad"));
            _projectUsers.Add("Samer");
            _projectUsers.Add("Mohammad");
            ProjectFactory("project2", _projectUsers, _projectTasks);

            ProjectFactory("project3");

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
        private static void ProjectFactory(string projectName, List<string> users, List<Task> tasks)
        {
            Project project = new(projectName, users, tasks);
            _projects.Add(project);
            //project.PrintProjectInfo();
            _projectUsers.Clear();
            _projectTasks.Clear();
        }
        private static void ProjectFactory(string projectName, List<string> users)
        {
            Project project = new(projectName, users);
            _projects.Add(project);
            _projectTasks.Clear();
            _projectUsers.Clear();
        }
        private static void ProjectFactory(string projectName, List<Task> tasks)
        {
            Project project = new(projectName, tasks);
            _projects.Add(project);
            _projectTasks.Clear();
            _projectUsers.Clear();
        }
        private static void ProjectFactory(string projectName)
        {
            Project project = new(projectName);
            _projects.Add(project);
            _projectTasks.Clear();
            _projectUsers.Clear();
        }
    }
}