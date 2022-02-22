using System.IO;

namespace Project_Management_Application
{
    public class Program
    {
        public static void Main(string []args)
        {
            List <Project> projects = new List <Project> ();
            Project p1 = new Project("project1", new string[2] { "Ahmad", "Salwa" });
            p1.Add_User("Noor");
            p1.Add_Task(new Task("task1", "descroiption for task1", "Ahmad"));
            List<Task> Pro2Tasks = new List<Task>();
            Pro2Tasks.Add(new Task("task1", "descroiption for task1", "Samer"));
            Pro2Tasks.Add(new Task("task2", "descroiption for task2", "Mohammad"));
            Project p2 = new Project("project2", new string[2] { "Samer", "Mohammad" },Pro2Tasks.ToList());
            projects.Add(p1);
            projects.Add(p2);
            string ProjectName = Console.ReadLine();
            foreach (var project in projects)
            {
                if (project.Project_name.Equals(ProjectName))
                {
                    project.print_project_info();
                }
            }
        }
    }
}