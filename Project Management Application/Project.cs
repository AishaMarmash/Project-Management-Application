using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Application
{
    internal class Project
    {
        public string ProjectName { get; set; }  
        public List<string> Contributors { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string name)
        {
            this.ProjectName = name;
            this.Contributors = new List<string>();
            this.Tasks = new List<Task>();
        }
        public Project(string name,List<string> contributors)
        {
            this.ProjectName = name;
            this.Contributors = contributors.ToList();
            this.Tasks = new List<Task>();
        }
        public Project(string name, List<Task> tasks)
        {
            this.ProjectName = name;
            this.Contributors = new List<string>();
            this.Tasks = tasks.ToList();
        }
        public Project(string name, List<string> contributors, List<Task> tasks)
        {
            this.ProjectName = name;
            Contributors = contributors.ToList();
            Tasks = tasks.ToList();
        }
        public void Addcontributor(string username)
        {
            Contributors.Add(username);
        }
        public void Add_Task(Task task)
        {
            Tasks.Add(task);
        }
        public void PrintProjectInfo()
        {
            Console.WriteLine($"project name : {ProjectName}{Environment.NewLine}" +
                $"it has {Contributors.Count} contributors and they are :{ string.Join(", ", Contributors)}{Environment.NewLine}" +
                $"It consists of multiple tasks:");
            foreach (var item in Tasks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
