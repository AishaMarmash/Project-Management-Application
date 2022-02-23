using System.IO;

namespace Project_Management_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List <Project> projects = new();
            Project p1 = new("project1", new string[2] { "Ahmad", "Salwa" });
            p1.AddUser("Noor");
            p1.Add_Task(new Task("task1", "descroiption for task1", "Ahmad"));
            List<Task> Pro2Tasks = new();
            Pro2Tasks.Add(new Task("task1", "description for task1", "Samer"));
            Pro2Tasks.Add(new Task("task2", "description for task2", "Mohammad"));
            Project p2 = new("project2", new string[2] { "Samer", "Mohammad" },Pro2Tasks.ToList());
            projects.Add(p1);
            projects.Add(p2);
            string ProjectName = Console.ReadLine();
            foreach (var project in projects)
            {
                if (project.ProjectName.Equals(ProjectName))
                {
                    project.PrintProjectInfo();
                }
            }
        }
    }
}