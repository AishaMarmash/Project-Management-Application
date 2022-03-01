using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class ProjectFactory
    {
        public static Project BuildProject(string projectName, List<string> contributors, List<Task> tasks)
        {
            Project project = new(projectName, contributors, tasks);
            return project;
        }
        public static Project BuildProject(string projectName, List<string> contributors)
        {
            Project project = new(projectName, contributors);
            return project;
        }
        public static Project BuildProject(string projectName, List<Task> tasks)
        {
            Project project = new(projectName, tasks);
            return project;
        }
        public static Project BuildProject(string projectName)
        {
            Project project = new(projectName);
            return project;
        }
        public static void PrintAllProjects(List <Project> projects)
        {
            foreach (var project in projects)
            {
                project.PrintProjectInfo();
                Console.WriteLine("============");
            }
        }
    }
}
